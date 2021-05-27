import { DecimalPipe } from '@angular/common';
import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Data, Params, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Activity } from 'src/app/_model/activity';
import { Carrier } from 'src/app/_model/carrier';
import { Commission } from 'src/app/_model/commission';
import { CommissionError } from 'src/app/_model/commissionError';
import { CommissionFinal } from 'src/app/_model/commissionFinal';
import { Product } from 'src/app/_model/product';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { CommissionService } from 'src/app/_service/commission.service';

enum commissionMode {
  Error= 'error',
  Final= 'final'
}

@Component({
  selector: 'app-commissionedit',
  templateUrl: './commissionedit.component.html',
  styleUrls: ['./commissionedit.component.css']
})
export class CommissionEditComponent implements OnInit, OnDestroy {
  carrierList: Carrier[];
  productList: Product[];
  activityList: Activity[];
  commission: Commission = {} as Commission;
  @ViewChild('editForm') editForm: NgForm;
  commissionMode: string;
  resolverSubscription: Subscription;
  paramsSubscription: Subscription;
  routeParamsSubscription: Subscription;
  statusDescription: string;
  deletingMode: boolean;
  readonly processStatusCode:string ='P';
  readonly errorStatusCode:string ='E';

  
  constructor(private route: ActivatedRoute, 
    private router: Router, private commissionService: CommissionService,
    private decimalPipe: DecimalPipe,
    private alertify: AlertifyService) { }

  ngOnInit(): void {
    this.resolverSubscription = this.route.data.subscribe(
      (dataresolve: Data) => {
           this.carrierList = dataresolve['carrier'];
           this.productList = dataresolve['product'];
          this.activityList = dataresolve['activity'];
          }
    );
    this.paramsSubscription = this.route.params.subscribe(
      (params: Params) => {      
        /*get the commission record;*/
        if (params) {

          if (params['commissionmode'] === commissionMode.Error) {
            this.commissionService.getErrordByID(+params['commissionid']).subscribe(
              retrieveRecord => {
                this.populateForm(retrieveRecord, commissionMode.Error);
              }
            );
          }
          else if (params['commissionmode'] === commissionMode.Final) {
            this.commissionService.getFinaldByID(+params['commissionid']).subscribe(
              retrieveRecord => {
                this.populateForm(retrieveRecord, commissionMode.Final);
              }
            );
          }
            
        }
      }
    );

    this.routeParamsSubscription = this.route.queryParams.subscribe(
      (queryparams) => {
        if (queryparams) {
          //console.log('query params');
          //console.log(queryparams);
        }        
      }
    );
  }

  ngOnDestroy() {
    if (this.resolverSubscription) {
      this.resolverSubscription.unsubscribe();
    }
    if (this.paramsSubscription) {
      this.paramsSubscription.unsubscribe();
    }
    if (this.routeParamsSubscription) {
      this.routeParamsSubscription.unsubscribe();
    }
  }

  Save() {
    if (this.commissionMode === commissionMode.Error) {            
      this.commissionService.updateError(this.populateCommissionErrorObject())
            .subscribe(
                      val => {
                          this.alertify.success('Record successfully saved');
                          this.commissionService.commissionSubject.next(true);        
                          this.close();
                      },
                      response => {
                          this.alertify.error('PUT call in error ' + response);
                      }   
            );
    }
    else if (this.commissionMode === commissionMode.Final) {            
      this.commissionService.updateFinal(this.populateCommissionFinalObject())
            .subscribe(
                      val => {
                          this.alertify.success('Record successfully saved');
                          this.commissionService.commissionSubject.next(true);        
                          this.close();
                      },
                      response => {
                          this.alertify.error('PUT call in error ' + response);
                      }   
            );
    }
  }

  populateForm(retrieveRecord: any, mode: string) {
    this.commission.commId = retrieveRecord.commId;
    this.commission.carrId = retrieveRecord.carrId;
    this.commission.prodId = retrieveRecord.prodId;
    this.commission.polNum = retrieveRecord.polNum;
    this.commission.yrNum = retrieveRecord.yrNum;    
    this.commission.actCd = retrieveRecord.actCd;              
    this.commission.statCd = retrieveRecord.statCd;
    
    switch (this.commission.statCd) {
      case 'E': {
        this.statusDescription = 'Error'; 
        break;
      }
      case 'N': {
        this.statusDescription = 'New';
        break;
      }
      case 'P': {
        this.statusDescription = 'Processed';
        break;
      }
      case 'R': {
        this.statusDescription = 'Reconciled';
        break;
      }
      default: {
        this.statusDescription = 'Not set';
        break;
      }
    }
    
    this.commission.grsPremAmt
    = this.decimalPipe.transform(retrieveRecord.grsPremAmt, '1.2');
    this.commission.commPremAmt 
    = this.decimalPipe.transform(retrieveRecord.commPremAmt, '1.2');
    this.commission.commRt 
    = this.decimalPipe.transform(retrieveRecord.commRt, '1.2');
    this.commission.commAmt
    = this.decimalPipe.transform(retrieveRecord.commAmt, '1.2');
    this.commissionMode = mode;
    this.commission.crtById = retrieveRecord.crtById;    
  }

  populateCommissionErrorObject(): CommissionError {    
    const commission: any = {};
    commission.commId = this.editForm.value.commId;
    commission.carrId = this.editForm.value.carrId;
    commission.polNum = this.editForm.value.polNum;
    commission.yrNum = this.editForm.value.yrNum;
    commission.prodId = this.editForm.value.prodId;
    commission.actCd  = this.editForm.value.actCd;
    commission.statCd = this.editForm.value.statCd;
    const currentTime  =   new Date(Date.now());
    currentTime.setHours(currentTime.getHours() + 8);
    commission.modDt = currentTime;
    commission.grsPremAmt = parseFloat( this.editForm.value.grsPremAmt.replace( /,/g , '' ) );
    commission.commPremAmt = parseFloat(this.editForm.value.commPremAmt.replace( /,/g , '' ));
    commission.commRt = parseFloat(this.editForm.value.commRt.replace( /,/g , '' ));
    commission.commAmt = parseFloat(this.editForm.value.commAmt.replace( /,/g , '' ));
    commission.crtById = this.editForm.value.crtById;
    commission.modById = localStorage.getItem('userName');
    return commission;
  }

  populateCommissionFinalObject(): CommissionFinal {    
    const commission: any = {};
    commission.commId = this.editForm.value.commId;
    commission.carrId = this.editForm.value.carrId;
    commission.polNum = this.editForm.value.polNum;
    commission.yrNum = this.editForm.value.yrNum;
    commission.prodId = this.editForm.value.prodId;
    commission.actCd  = this.editForm.value.actCd;
    commission.statCd = this.editForm.value.statCd;
    const currentTime  =   new Date(Date.now());
    currentTime.setHours(currentTime.getHours() + 8);
    commission.modDt = currentTime;
    commission.grsPremAmt = parseFloat( this.editForm.value.grsPremAmt.replace( /,/g , '' ) );
    commission.commPremAmt = parseFloat(this.editForm.value.commPremAmt.replace( /,/g , '' ));
    commission.commRt = parseFloat(this.editForm.value.commRt.replace( /,/g , '' ));
    commission.commAmt = parseFloat(this.editForm.value.commAmt.replace( /,/g , '' ));
    commission.crtById = this.editForm.value.crtById;
    commission.modById = localStorage.getItem('userName');
    return commission;
  }

  errorMode() {
    if ( this.commissionMode === commissionMode.Error ){
      return true;
    }
    else
    {
      return false;
    }
  }
  
  process() {
    if (this.commissionMode === commissionMode.Error) {
        this.editForm.value.statCd = this.processStatusCode;                
      this.commissionService.processError(this.populateCommissionErrorObject())
            .subscribe(
                      val => {                          
                          this.alertify.success('Record successfully process');
                          this.commissionService.commissionSubject.next(true);        
                          this.close();
                      },
                      response => {
                          this.alertify.error('PUT call in error ' + response);
                      }   
            );
    }
  }

  revalidate() {
    if (this.commissionMode === commissionMode.Final) {
        this.editForm.value.statCd = this.errorStatusCode;                
      this.commissionService.revalidateFinal(this.populateCommissionFinalObject())
            .subscribe(
                      val => {                          
                          this.alertify.success('Record successfully revalidate');
                          this.commissionService.commissionSubject.next(true);        
                          this.close();
                      },
                      response => {
                          this.alertify.error('PUT call in error ' + response);
                      }   
            );
    }
  }

  delete() {      
      this.deletingMode = true;
  }
  confirm() {
    this.commissionService.deleteError(this.editForm.value.commId).subscribe(
      success => {
        this.alertify.success('Record successfully deleted');        
      },
      err =>{
        this.alertify.error('Record not deleted' + err);
      },
      () => {
        this.commissionService.commissionSubject.next(true);        
        this.close();
      }
    );
  }
  
  decline() {
    this.deletingMode = false;
  }

  close() {
    this.router.navigate(['../../../'], {relativeTo: this.route});    
  }

}
