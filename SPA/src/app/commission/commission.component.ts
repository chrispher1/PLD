import { Component, OnInit, TemplateRef, ViewChild, ElementRef, OnDestroy } from '@angular/core';
import { CommissionService } from '../_service/commission.service';
import { CommissionError } from '../_model/commissionError';
import { Commission} from '../_model/commission';
import { AlertifyService } from '../_service/alertify.service';
import { Pagination } from '../_model/pagination';
import { ActivatedRoute } from '@angular/router';
import { Carrier } from '../_model/carrier';
import { Product } from '../_model/product';
import { Activity } from '../_model/activity';
import { Status } from '../_model/status';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { CommissionDetailComponent } from './commissiondetail/commissiondetail.component';
import { ExcelService } from '../_service/excel.service';
import { of, Observable, Subscription } from 'rxjs';
import { map } from 'rxjs/operators';
import { NgForm } from '@angular/forms';

enum mode {Add = 1, Edit = 2}

@Component({
  selector: 'app-commission',
  templateUrl: './commission.component.html',
  styleUrls: ['./commission.component.css']
})
export class CommissionComponent implements OnInit, OnDestroy {  

  constructor(private commissionservice: CommissionService, 
    private alertify: AlertifyService, private route: ActivatedRoute,
    private modalService: BsModalService,
    private excelService: ExcelService ) {
    }
  commissionErrorList: CommissionError[];
  carrierErrorList: Carrier[];
  productErrorList: Product[];  
  activityErrorList: Activity[];  
  statusErrorList: Status[];
  paginationcommissionError: Pagination;
  commissionErrorSearchParam: any = {};
  @ViewChild('errorForm') errorForm: NgForm;
  errorListSubscription: Subscription;

  
  commissionErrorRecord: CommissionError;
  modalDeleteCommissionErrorRef: BsModalRef;
  commissionErrorRecordForDelete: CommissionError;
  multiDelete: boolean;
  @ViewChild('AllCommissionErrorCheckbox') AllCommissionErrorCheckbox: ElementRef;

  ngOnInit() {    
    this.route.data.subscribe(data =>
      {
        this.commissionErrorList =    data['commissionError'].result;
        this.paginationcommissionError = data['commissionError'].pagination;
        this.carrierErrorList = data['carrier'];
        this.productErrorList = data['product'];  
        this.activityErrorList = data['activity'];
        this.statusErrorList = data['status'];     
      }
    );
    
    this.commissionErrorSearchParamSetDefaultValue();
    
    this.errorListSubscription = this.commissionservice.errorSubject.subscribe(
      updateflag =>{
        this.loadCommissionError();
        console.log('Reloads Commission Error records');
      }
    );
  } 
  
  ngOnDestroy(){
    this.errorListSubscription.unsubscribe();
    console.log('errorListSubscription.unsubscribe');
  }

  commissionErrorSearchParamSetDefaultValue() {
    this.commissionErrorSearchParam.carrier = -1 ;
    this.commissionErrorSearchParam.product = -1 ;
    this.commissionErrorSearchParam.policyNumber = '';
    this.commissionErrorSearchParam.policyYearMin = '';
    this.commissionErrorSearchParam.policyYearMax = '';
    this.commissionErrorSearchParam.activity = -1;
    this.commissionErrorSearchParam.grossPremiumAmountMin = '';
    this.commissionErrorSearchParam.grossPremiumAmountMax = '';
    this.commissionErrorSearchParam.commissionPremiumAmountMin = '';
    this.commissionErrorSearchParam.commissionPremiumAmountMax = '';
    this.commissionErrorSearchParam.commissionRateMin = '';
    this.commissionErrorSearchParam.commissionRateMax = '';
    this.commissionErrorSearchParam.commissionAmountMin = '';
    this.commissionErrorSearchParam.commissionAmountMax = '';
    this.commissionErrorSearchParam.status = -1;
    this.commissionErrorSearchParam.transactionDateMin = '';
    this.commissionErrorSearchParam.transactionDateMax = '';
  }

  commissionErrorResetFilter() {           
    this.errorForm.form.patchValue({
        SearchParam: { 
          carrier: -1,
          product: -1 ,
          policyNumber: '',
          policyYearMin: '',
          policyYearMax: '',
          activity: -1,
          grossPremiumAmountMin: '',
          grossPremiumAmountMax: '',
          commissionPremiumAmountMin: '',
          commissionPremiumAmountMax: '',
          commissionRateMin: '',
          commissionRateMax: '',
          commissionAmountMin: '',
          commissionAmountMax: '',
          status: -1,
          transactionDateMin: '',
          transactionDateMax: '' 
        } 
      }
    )
  }
  
  exportAsXLSX(): void {    
    this.excelService.exportAsExcelFile(this.commissionErrorList, 'sample');
 }

  pageChanged(event: any): void {
    this.paginationcommissionError.currentPage = event.page;    
    this.loadCommissionError();     
  }

  loadCommissionError()  {    
    this.commissionservice.getAllError(this.paginationcommissionError.currentPage, 10, 
      this.errorForm.value.SearchParam).subscribe(list => {
      this.commissionErrorList = list.result;
      this.paginationcommissionError = list.pagination;  
      this.AllCommissionErrorCheckbox.nativeElement['checked'] = false;     
    }
      , error => {
        this.alertify.error('Cannot load commission errors record');
      }      
    );
    
  }

  loadCommissionFinal()  {
  }


  openModalWithComponent(event: Event, button: String, commissionError: CommissionError, transactionMode: Number) {
    //event.preventDefault();
    //event.stopPropagation();    
    //transactionMode = 3;

    /*

    let commissionRecord = {} as Commission;

    if (transactionMode === mode.Add) {
      commissionRecord.carrId = null;
      commissionRecord.prodId = null;
      commissionRecord.actCd = null;
      commissionRecord.statCd = null;

      const initialState = {
        commissionRecord: commissionRecord
        , carrierList: this.carrierErrorList
        , productList: this.productErrorList
        , activityList: this.activityErrorList
        , statusList: this.statusErrorList
        , transactionMode: mode.Add
      };
      this.bsModalRef = this.modalService.show(CommissionDetailComponent, {initialState});
      this.bsModalRef.setClass('modal-dialog-centered modal-lg');
      this.bsModalRef.content.action.subscribe(
        data =>
        {              
          this.loadCommissionError();
        },
        error => {
          this.alertify.error('error in fetching record' + error);
        }
      );
    }
    else if (transactionMode === mode.Edit) {       
      this.commissionservice.getErrordByID(commissionError.commId)
      .subscribe( data => {
        this.commissionErrorRecord = data;
        commissionRecord.commId = this.commissionErrorRecord.commId;      
        commissionRecord.carrId = this.commissionErrorRecord.carrId;
        commissionRecord.polNum = this.commissionErrorRecord.polNum;
        commissionRecord.yrNum = this.commissionErrorRecord.yrNum;
        commissionRecord.prodId = this.commissionErrorRecord.prodId;
        commissionRecord.actCd  = this.commissionErrorRecord.actCd;
        commissionRecord.statCd = this.commissionErrorRecord.statCd;

        if (commissionError.grsPremAmt !== null) {
          commissionRecord.grsPremAmt = this.commissionErrorRecord.grsPremAmt.toString();      
        }
        if (commissionError.commPremAmt !== null) {
          commissionRecord.commPremAmt = this.commissionErrorRecord.commPremAmt.toString();
        }
        if (commissionError.commRt !== null) {
          commissionRecord.commRt = this.commissionErrorRecord.commRt.toString();
        }
        if (commissionError.commAmt !== null) {
          commissionRecord.commAmt = this.commissionErrorRecord.commAmt.toString();
        }
    
        const initialState = {
          commissionRecord: commissionRecord
          , carrierList: this.carrierErrorList
          , productList: this.productErrorList
          , activityList: this.activityErrorList
          , statusList: this.statusErrorList
          , transactionMode: mode.Edit
        };
        this.bsModalRef = this.modalService.show(CommissionDetailComponent, {initialState});
        this.bsModalRef.setClass('modal-dialog-centered modal-lg');
        this.bsModalRef.content.action.subscribe(
          data =>
          {
            this.loadCommissionError();
          },
          error => {
            this.alertify.error('error in fetching record' + error);
          }
        );
      }
      );
    }
    */
  }

  openCommissionErrorDeleteModal(template: TemplateRef<any>, commissionError: CommissionError) {
    this.modalDeleteCommissionErrorRef = this.modalService.show(template, {class: 'modal-dialog-centered modal-sm'});
    this.commissionErrorRecordForDelete = commissionError;
    this.multiDelete = false;
  }

  openCommissionErrorMultiDeleteModal(template: TemplateRef<any>) {
    this.modalDeleteCommissionErrorRef = this.modalService.show(template, {class: 'modal-dialog-centered modal-sm'});
    this.multiDelete = true;
  }

  confirm(): void {    
    if (this.multiDelete) {      
      let commissionErrorDeletedList: CommissionError[] = [];
      for(let commissionErrorDeleted of this.commissionErrorList) {        
        if (commissionErrorDeleted.isDeleted){
          commissionErrorDeletedList.push(commissionErrorDeleted);
        }  
      }      
      this.commissionservice.deleteMultiError( commissionErrorDeletedList)
      .subscribe(
        success => {
          this.loadCommissionError();
        },
        error => {
          this.alertify.error('Multi delete of commission error:' + error);
        },
        () => {
            this.modalDeleteCommissionErrorRef.hide();
        }
      );
      
    }
    else if( !this.multiDelete ) {
      this.commissionservice.deleteError(this.commissionErrorRecordForDelete).subscribe(
        success => {
          this.alertify.success('Record successfully deleted');
          this.loadCommissionError();
        },
        err =>{
          this.alertify.error('Record not deleted' + err);
        },
        () => {
          this.modalDeleteCommissionErrorRef.hide();
        }
      );
    }
  }
 
  decline(): void {
    this.modalDeleteCommissionErrorRef.hide();
  }

  allCommissionError(event) {
    const checked = event.target.checked;
    this.commissionErrorList.forEach( item => item.isDeleted = checked);
  }
  commissionErrorItemSelected() {
    let checked = true;    
    this.commissionErrorList.forEach( 
      item => {
        if( !item.isDeleted ) {
          checked = false;
        }
      }      
      );
      this.AllCommissionErrorCheckbox.nativeElement['checked'] = checked;     
  }

  keyUpEnterKey(){    
    this.loadCommissionError();
  }
}


