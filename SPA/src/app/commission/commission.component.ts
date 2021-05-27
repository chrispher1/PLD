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
import { FormControl, FormGroup, NgForm } from '@angular/forms';
import { CommissionFinal } from '../_model/commissionFinal';
import { CommissionAll } from '../_model/commission-all';

enum mode {Add = 1, Edit = 2}

@Component({
  selector: 'app-commission',
  templateUrl: './commission.component.html',
  styleUrls: ['./commission.component.css']
})
export class CommissionComponent implements OnInit, OnDestroy {
  
  constructor(private commissionService: CommissionService, 
    private alertify: AlertifyService, private route: ActivatedRoute,
    private modalService: BsModalService,
    private excelService: ExcelService ) {
    }

  commissionErrorList: CommissionError[];
  commissionFinalList: CommissionFinal[];
  commissionAllList: Commission[];
  
  carrierErrorList: Carrier[];
  productErrorList: Product[];  
  activityErrorList: Activity[];  
  statusErrorList: Status[];
  carrierFinalList: Carrier[];
  productFinalList: Product[];  
  activityFinalList: Activity[];  
  statusFinalList: Status[];
  carrierAllList: Carrier[];
  productAllList: Product[];  
  activityAllList: Activity[];  
  statusAllList: Status[];
  paginationcommissionError: Pagination;
  paginationcommissionFinal: Pagination;
  paginationcommissionAll: Pagination;

  commissionErrorSearchParam: any = {};
  @ViewChild('errorForm') errorForm: NgForm;
  commissionListSubscription: Subscription;
  commissionErrorRecord: CommissionError;
  modalDeleteCommissionErrorRef: BsModalRef;
  modalRevalidateCommissionRef: BsModalRef;

  commissionErrorRecordForDelete: CommissionError;
  commissionFinalRecordForRevalidate: CommissionFinal;

  multiDelete: boolean;
  multiRevalidate: boolean;

  @ViewChild('AllCommissionErrorCheckbox') AllCommissionErrorCheckbox: ElementRef;
  @ViewChild('AllCommissionFinalCheckbox') AllCommissionFinalCheckbox: ElementRef;

  finalForm: FormGroup;
  allForm: FormGroup;  

  ngOnInit() {    
    this.route.data.subscribe(data =>
      {
        this.commissionErrorList =    data['commissionError'].result;
        this.paginationcommissionError = data['commissionError'].pagination;
        this.carrierErrorList = data['carrier'];
        this.productErrorList = data['product'];  
        this.activityErrorList = data['activity'];
        this.statusErrorList = data['status'];     
        this.carrierFinalList = data['carrier'];
        this.productFinalList = data['product'];  
        this.activityFinalList = data['activity'];
        this.statusFinalList = data['status'];    
        this.carrierAllList = data['carrier'];
        this.productAllList = data['product'];  
        this.activityAllList = data['activity'];
        this.statusAllList = data['status'];  

        this.commissionFinalList = data['commissionFinal'].result;
        this.paginationcommissionFinal = data['commissionFinal'].pagination;

        this.commissionAllList = data['commissionAll'].result;
        this.paginationcommissionAll = data['commissionAll'].pagination;
      }
    );
    
    this.commissionErrorSearchParamSetDefaultValue();
    
    this.commissionListSubscription = this.commissionService.commissionSubject.subscribe(
      updateflag =>{
        this.loadCommissionError();
        this.loadCommissionFinal();
        this.loadCommissionAll();
        console.log('Reloads commission records');
      }
    );

    this.commissionFinalSearchParamSetDefaultValue();
    this.commissionAllSearchParamSetDefaultValue();
    
  } 
  
  ngOnDestroy(){
    this.commissionListSubscription.unsubscribe();
    console.log('commissionListSubscription.unsubscribe');
  }

  commissionFinalSearchParamSetDefaultValue() {
    this.finalForm = new FormGroup(
      {
        'searchParam': new FormGroup({
          'carrier': new FormControl(-1),
        'product': new FormControl(-1),
        'policyNumber': new FormControl(''),
        'policyYearMin': new FormControl(''),
        'policyYearMax': new FormControl(''),
        'activity': new FormControl(-1),
        'grossPremiumAmountMin': new FormControl(''),
        'grossPremiumAmountMax': new FormControl(''),
        'commissionPremiumAmountMin': new FormControl(''),
        'commissionPremiumAmountMax': new FormControl(''),
        'commissionRateMin': new FormControl('', this.validateRateValue.bind(this)),
        'commissionRateMax': new FormControl('', this.validateRateValue.bind(this)),
        'commissionAmountMin': new FormControl(''),
        'commissionAmountMax': new FormControl(''),
        'status': new FormControl(-1),
        'transactionDateMin': new FormControl(''),
        'transactionDateMax': new FormControl('')
        })
      }
    );
  }

  commissionAllSearchParamSetDefaultValue() {
    this.allForm = new FormGroup(
      {
        'searchParam': new FormGroup({
          'carrier': new FormControl(-1),
        'product': new FormControl(-1),
        'policyNumber': new FormControl(''),
        'policyYearMin': new FormControl(''),
        'policyYearMax': new FormControl(''),
        'activity': new FormControl(-1),
        'grossPremiumAmountMin': new FormControl(''),
        'grossPremiumAmountMax': new FormControl(''),
        'commissionPremiumAmountMin': new FormControl(''),
        'commissionPremiumAmountMax': new FormControl(''),
        'commissionRateMin': new FormControl('', this.validateRateValue.bind(this)),
        'commissionRateMax': new FormControl('', this.validateRateValue.bind(this)),
        'commissionAmountMin': new FormControl(''),
        'commissionAmountMax': new FormControl(''),
        'status': new FormControl(-1),
        'transactionDateMin': new FormControl(''),
        'transactionDateMax': new FormControl('')
        })
      }
    );
  }

  validateRateValue(control: FormControl): {[s:string]: boolean } {
    if (((control.value > 100) || (control.value < 1)) && ((control.value!==null) && (control.value !=='')) )
      return {'IsOutOfRange': true};
    return null;
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

  commissionFinalResetFilter() {
    this.finalForm.patchValue({
        searchParam: {
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
    );
  }

  commissionAllResetFilter() {
    
    this.allForm.patchValue({
        searchParam: {
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
    );
    
  }

  commissionErrorResetFilter() {
    this.errorForm.form.patchValue({
        searchParam: { 
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
    );
  }
  
  exportAsXLSX(): void {    
    this.excelService.exportAsExcelFile(this.commissionErrorList, 'sample');
 }

  pageErrorChanged(event: any): void {
    this.paginationcommissionError.currentPage = event.page;    
    this.loadCommissionError();     
  }

  pageFinalChanged(event: any): void {
    this.paginationcommissionFinal.currentPage = event.page;      
    this.loadCommissionFinal();     
  }

  pageAllChanged(event: any): void {
    this.paginationcommissionAll.currentPage = event.page;      
    this.loadCommissionAll();     
  }

  loadCommissionError()  {    
    this.commissionService.getAllError(this.paginationcommissionError.currentPage, 
      this.paginationcommissionError.itemsPerPage, 
      this.errorForm.value.searchParam).subscribe(list => {
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
    /*console.log("this.finalForm:");
    console.log(this.finalForm);*/


    this.commissionService.getAllFinal(this.paginationcommissionFinal.currentPage, 
      this.paginationcommissionFinal.itemsPerPage, 
      this.finalForm.value.searchParam).subscribe(list => {
      this.commissionFinalList = list.result;
      this.paginationcommissionFinal = list.pagination;  
      this.AllCommissionFinalCheckbox.nativeElement['checked'] = false;     
    }
      , error => {
        this.alertify.error('Cannot load commission final record');
      }      
    );
  }
  
  loadCommissionAll()  {      
    /*console.log("this.finalForm:");
    console.log(this.finalForm);*/

    this.commissionService.getAll(this.paginationcommissionAll.currentPage, 
      this.paginationcommissionAll.itemsPerPage, 
      this.allForm.value.searchParam).subscribe(list => {
      
      this.commissionAllList = list.result;
      this.paginationcommissionAll = list.pagination;  
      //this.AllCommissionFinalCheckbox.nativeElement['checked'] = false;     
    }
      , error => {
        this.alertify.error('Cannot load commission all record');
      }      
    );
    
  }

  openModalWithComponent(event: Event, button: String, commissionError: CommissionError, transactionMode: Number) {    
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

  openCommissionFinalRevalidateModal(template: TemplateRef<any>, commissionFinal: CommissionFinal) {
    this.modalRevalidateCommissionRef = this.modalService.show(template, {class: 'modal-dialog-centered modal-sm'});
    this.commissionFinalRecordForRevalidate = commissionFinal;
    this.multiRevalidate = false;
  }

  openCommissionMultiRevalidateModal(template: TemplateRef<any>) {
    this.modalRevalidateCommissionRef = this.modalService.show(template, {class: 'modal-dialog-centered modal-sm'});
    this.multiRevalidate = true;
  }

  confirmRevalidate(): void {  
    if (this.multiRevalidate) {           
      let commissionIdList: number[] = [];
      for(let commissionFinalRevalidated of this.commissionFinalList) {        
        if (commissionFinalRevalidated.isRevalidated) {
          commissionIdList.push(commissionFinalRevalidated.commId);
        }  
      }  
      this.commissionService.revalidateMultiFinal( commissionIdList )
      .subscribe(
        success => {
          this.alertify.success('Record(s) successfully revalidated');
          this.commissionService.commissionSubject.next(true); 
        },
        error => {
          this.alertify.error('Multi revalidate of commission error:' + error);
        },
        () => {
            this.modalRevalidateCommissionRef.hide();
        }
      );

    }
    else if( !this.multiRevalidate ) {
      this.commissionService.revalidateFinal(this.commissionFinalRecordForRevalidate).subscribe(
        success => {
          this.alertify.success('Record successfully revalidated');
          this.commissionService.commissionSubject.next(true); 
        },
        err =>{
          this.alertify.error('Record not revalidated' + err);
        },
        () => {
          this.modalRevalidateCommissionRef.hide();
        }
      );
    }    
  }
  confirm(): void {    
    if (this.multiDelete) {           
      let commissionIdList: number[] = [];
      for(let commissionErrorDeleted of this.commissionErrorList) {        
        if (commissionErrorDeleted.isDeleted) {
          commissionIdList.push(commissionErrorDeleted.commId);
        }  
      }      
      this.commissionService.deleteMultiError( commissionIdList )
      .subscribe(
        success => {
          this.alertify.success('Record(s) successfully deleted');
          this.commissionService.commissionSubject.next(true); 
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
      this.commissionService.deleteError(this.commissionErrorRecordForDelete.commId).subscribe(
        success => {
          this.alertify.success('Record successfully deleted');
          this.commissionService.commissionSubject.next(true); 
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
 
  declineRevalidate(): void {
    this.modalRevalidateCommissionRef.hide();
  }

  decline(): void {
    this.modalDeleteCommissionErrorRef.hide();
  }

  allCommissionError(event) {
    const checked = event.target.checked;
    this.commissionErrorList.forEach( item => item.isDeleted = checked);
  }

  allCommissionFinal(event) {
    const checked = event.target.checked;
    this.commissionFinalList.forEach( item => item.isRevalidated = checked);
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

  commissionFinalItemSelected() {
    let checked = true;    
    this.commissionFinalList.forEach( 
      item => {
        if( !item.isRevalidated ) {
          checked = false;
        }
      }      
      );
      this.AllCommissionFinalCheckbox.nativeElement['checked'] = checked;     
  }

}


