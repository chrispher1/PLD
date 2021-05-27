import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

// NgModule decorator is needed when creating Module
import { NgModule } from '@angular/core';
// RouterModule is needed when configuring router Module
import { RouterModule } from '@angular/router';

// Modules of ngx-bootstrap
import { BsDropdownModule} from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { ModalModule } from 'ngx-bootstrap/modal';

// FormsModule is required to import when using Angular forms
// RecativeFormsModule is required to be import when using Reactive forms
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { HttpClientModule } from '@angular/common/http';
import { routes } from './routes.routing';
import { JwtModule } from '@auth0/angular-jwt';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { CommissionComponent } from './commission/commission.component';
import { CaseComponent } from './case/case.component';
import { PaymentComponent } from './payment/payment.component';
import { CommissionDetailComponent} from './commission/commissiondetail/commissiondetail.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

import {CommissionService} from './_service/commission.service';
import { AlertifyService } from './_service/alertify.service';
import { ProductService } from './_service/product.service';
import { ProductListResolver } from './_resolvers/productlistresolver';
import { ActivityService } from './_service/activity.service';
import { StatusService } from './_service/status.service';
import { AuthService } from './_service/auth.service';

import {CommissionDetailResolver} from './_resolvers/commissiondetailresolver';
import { CommissionErrorListResolver } from './_resolvers/commissionerrorlistresolver';
import { CarrierListResolver } from './_resolvers/carrierlistresolver';
import { ActivityListResolver } from './_resolvers/activitylistresolver';
import { StatusListResolver } from './_resolvers/statuslistresolver';

import { ErrorInterceptorProvider } from './_service/error.interceptor';

import { PolicyNumberValidatorDirective } from './_directives/policyNumberValidator.directive';
import { CarrierValidatorDirective } from './_directives/carrierValidator.directive';
import { ActivityValidatorDirective } from './_directives/activityValidator.directive';
import { ProductValidatorDirective } from './_directives/productValidator.directive';
import { StatusValidatorDirective } from './_directives/statusValidator.directive';
import { NumberOnlyDirective } from './_directives/numberOnly.directive';
import { NumericDirective } from './_directives/numeric.directive';
import { CurrencyDirective } from './_directives/currency.directive';

import { CurrencyPipe } from './_pipe/currency.pipe';
import { DecimalPipe } from '@angular/common';
import { BarcodePipe } from './_pipe/barcode.pipe';
import { ExcelService } from './_service/excel.service';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { ProductComponent } from './product/product.component';
import { RateComponent } from './rate/rate.component';
import { TransactionTypeComponent} from './transactiontype/transactiontype.component';
import { CommissionNewComponent } from './commission/commission-new/commission-new.component';
import { CommissionEditComponent } from './commission/commissionedit/commissionedit.component';
import { RateValidatorDirective } from './_directives/rate-validator.directive';
import { CommissionFinalListResolver } from './_resolvers/commissionfinallist.resolver';
import { StatusListForCommissionFormResolver } from './_resolvers/statuslistforcommissionform.resolver';
import { CommissionAllListResolver } from './_resolvers/commissionalllist.resolver';

export function tokenGetter() {   
   return localStorage.getItem('token');
 }

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      CommissionComponent,
      CaseComponent,
      PaymentComponent,
      CommissionDetailComponent,
      HomeComponent,
      LoginComponent,
      RegisterComponent,      
      PolicyNumberValidatorDirective,
      CarrierValidatorDirective,
      ActivityValidatorDirective,
      ProductValidatorDirective,
      StatusValidatorDirective,
      NumberOnlyDirective,
      NumericDirective,
      CurrencyDirective,
      CurrencyPipe,      
      BarcodePipe,
      PagenotfoundComponent,
      ProductComponent,
      RateComponent,
      TransactionTypeComponent,
      CommissionNewComponent,
      CommissionEditComponent,
      RateValidatorDirective
   ],
   entryComponents: [ CommissionDetailComponent],
   imports: [
      BrowserModule,
      RouterModule.forRoot(routes,         
               { enableTracing: false } // <-- debugging purposes only
         ),
      BsDropdownModule.forRoot(),
      TabsModule.forRoot(),
      FormsModule,
      ReactiveFormsModule,
      HttpClientModule,
      PaginationModule.forRoot(),
      JwtModule.forRoot({
         config: {
           tokenGetter: tokenGetter,
           allowedDomains: ['localhost:5000'],
           disallowedRoutes: ['localhost:5000/api/auth']
         }
       }),
       ModalModule.forRoot(),
       BrowserAnimationsModule,
       BsDatepickerModule.forRoot()
   ],
   providers: [
      CommissionService,
      CommissionDetailResolver,
      AlertifyService,
      CommissionErrorListResolver,
      CommissionFinalListResolver,
      CarrierListResolver,
      ProductService,
      ProductListResolver,
      ActivityService,
      ActivityListResolver,
      StatusService,
      StatusListResolver,
      StatusListForCommissionFormResolver,
      AuthService,
      ErrorInterceptorProvider,
      DecimalPipe,
      CurrencyPipe,
      ExcelService,
      CommissionAllListResolver      
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
