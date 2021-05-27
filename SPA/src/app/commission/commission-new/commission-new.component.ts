import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Data, Route, Router } from '@angular/router';
import { Activity } from 'src/app/_model/activity';
import { Carrier } from 'src/app/_model/carrier';
import { CommissionError } from 'src/app/_model/commissionError';
import { Product } from 'src/app/_model/product';
import { Status } from 'src/app/_model/status';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { CommissionService } from 'src/app/_service/commission.service';

@Component({
  selector: 'app-commission-new',
  templateUrl: './commission-new.component.html',
  styleUrls: ['./commission-new.component.css']
})
export class CommissionNewComponent implements OnInit, OnDestroy {
  carrierList: Carrier[];
  productList: Product[];
  activityList: Activity[];
  statusList: Status[];
  @ViewChild('newForm') newForm: NgForm;
  commissionError: CommissionError = {} as CommissionError;
  
  constructor(private router: Router,  private route: ActivatedRoute,
    private commissionService: CommissionService, private alertify: AlertifyService) { }

  ngOnInit(): void {
    this.route.data.subscribe (
      (resolverData: Data) => {
        this.carrierList = resolverData['carrier'];
        this.productList = resolverData['product'];
        this.activityList = resolverData['activity'];
        this.statusList = resolverData['status'];        
      },
      error => {
        console.log('Error in loading resolvers');
        console.log(error);
      }

    );
  }

  ngOnDestroy() {
    console.log('commission new destroyed');
  }

  close(){
    this.router.navigate( ['../'], {relativeTo: this.route} );  
  }
  
  save() {
    this.commissionError.carrId = this.newForm.value.carrId;
    this.commissionError.prodId = this.newForm.value.prodId;
    this.commissionError.polNum = this.newForm.value.polNum;
    this.commissionError.yrNum = this.newForm.value.yrNum;    
    this.commissionError.actCd = this.newForm.value.actCd;
    this.commissionError.grsPremAmt = +this.newForm.value.grsPremAmt;
    this.commissionError.commPremAmt = +this.newForm.value.commPremAmt;
    this.commissionError.commPremAmt = +this.newForm.value.commPremAmt;
    this.commissionError.commRt = +this.newForm.value.commRt;
    this.commissionError.commAmt = +this.newForm.value.commAmt;
    this.commissionError.statCd = this.newForm.value.statCd;
    const currentDate = new Date();    
    this.commissionError.crtDt = currentDate;
    this.commissionError.crtById = localStorage.getItem('userName');   

    this.commissionService.addError(this.commissionError).subscribe(
      success => {           
        this.alertify.success('New record saved');
        this.commissionService.commissionSubject.next(true);        
        this.close();
      },
      error => {
        console.log(error);
      }
    );    
  }
}
