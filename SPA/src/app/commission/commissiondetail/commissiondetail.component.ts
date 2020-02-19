import { Component, OnInit, ViewChild, ElementRef, Output, EventEmitter, OnDestroy } from '@angular/core';
import { CommissionError } from '../../_model/commissionError';
import { ActivatedRoute } from '@angular/router';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { Carrier } from '../../_model/carrier';
import { Product } from '../../_model/product';
import { Activity } from '../../_model/activity';
import { Status } from '../../_model/status';
import { DecimalPipe, formatDate } from '@angular/common';
import { Commission } from '../../_model/commission';
import { CommissionService } from 'src/app/_service/commission.service';

enum mode {Add = 1, Edit = 2}

@Component({
  selector: 'app-commissiondetail',
  templateUrl: './commissiondetail.component.html',
  styleUrls: ['./commissiondetail.component.css']
})

export class CommissionDetailComponent implements OnInit, OnDestroy {
  commissionRecord: Commission; 
  carrierList: Carrier[];
  productList: Product[];
  activityList: Activity[];
  statusList: Status[];  
  @Output() action = new EventEmitter();  
  @ViewChild('prodId', {read: ElementRef})
  sample: ElementRef;
  
  transactionMode: Number;
  constructor( private route: ActivatedRoute, 
    private alertify: AlertifyService,
    public bsModalRef: BsModalRef,
    private decimalPipe: DecimalPipe,
    private commissionService: CommissionService
    ) { }
    
    ngOnDestroy(){
      this.closeModal();
    }

  ngOnInit() {
    this.commissionRecord.grsPremAmt = this.decimalPipe.transform(this.commissionRecord.grsPremAmt, '1.2');
    this.commissionRecord.commPremAmt = this.decimalPipe.transform(this.commissionRecord.commPremAmt, '1.2');
    this.commissionRecord.commRt = this.decimalPipe.transform(this.commissionRecord.commRt, '1.2');
    this.commissionRecord.commAmt = this.decimalPipe.transform(this.commissionRecord.commAmt, '1.2');  

  }

  updateCommission() {    
    let commission = {} as CommissionError;
    if (this.transactionMode === mode.Add) {      
          commission.carrId = this.commissionRecord.carrId;
          commission.polNum = this.commissionRecord.polNum;
          commission.yrNum = this.commissionRecord.yrNum;
          commission.prodId = this.commissionRecord.prodId;
          commission.actCd  = this.commissionRecord.actCd;
          commission.statCd = this.commissionRecord.statCd;          
          commission.grsPremAmt = parseFloat( this.commissionRecord.grsPremAmt.replace( /,/g , '' ) );
          commission.commPremAmt = parseFloat(this.commissionRecord.commPremAmt.replace( /,/g , '' ));
          commission.commRt = parseFloat(this.commissionRecord.commRt.replace( /,/g , '' ));
          commission.commAmt = parseFloat(this.commissionRecord.commAmt.replace( /,/g , '' ));          
          let currentTime  =   new Date(Date.now());
          currentTime.setHours(currentTime.getHours() + 8);
          commission.crtDt = currentTime;
          commission.crtById = localStorage.getItem('userName');
          this.commissionService.addError(commission)
          .subscribe(
            data => {
              commission = data;
              this.commissionRecord.commId = commission.commId;
              this.transactionMode = mode.Edit;
              this.alertify.success('Record successfully saved');
              this.action.emit(true);   
            },
            error => {
              this.alertify.error('Error during adding:' + error);
            }
          );
    }
    else if (this.transactionMode === mode.Edit) {      
      this.commissionService.getErrordByID(this.commissionRecord.commId)
      .subscribe( 
        data => {
          commission = data;
          commission.commId = this.commissionRecord.commId;
          commission.carrId = this.commissionRecord.carrId;
          commission.polNum = this.commissionRecord.polNum;
          commission.yrNum = this.commissionRecord.yrNum;
          commission.prodId = this.commissionRecord.prodId;
          commission.actCd  = this.commissionRecord.actCd;
          commission.statCd = this.commissionRecord.statCd;
          let currentTime  =   new Date(Date.now());
          currentTime.setHours(currentTime.getHours() + 8);
          commission.modDt = currentTime;
          commission.grsPremAmt = parseFloat( this.commissionRecord.grsPremAmt.replace( /,/g , '' ) );
          commission.commPremAmt = parseFloat(this.commissionRecord.commPremAmt.replace( /,/g , '' ));
          commission.commRt = parseFloat(this.commissionRecord.commRt.replace( /,/g , '' ));
          commission.commAmt = parseFloat(this.commissionRecord.commAmt.replace( /,/g , '' ));
          commission.modById = localStorage.getItem('userName');
          this.commissionService.updateError(commission)
            .subscribe(
                      val => {
                          this.alertify.success('Record successfully saved');
                          this.action.emit(true);                     
                      },
                      response => {
                          this.alertify.error('PUT call in error ' + response);
                      }   
            );
        },
        error => {
          this.alertify.error('Error calling record of commission');
        }
      );
    }
  }
  
  closeModal() {    
    if (!this.bsModalRef) {
      return;
    }
    this.bsModalRef.hide();
    this.bsModalRef = null;
    event.stopPropagation();
  }
}
