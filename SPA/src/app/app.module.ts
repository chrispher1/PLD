import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BsDropdownModule, TabsModule, BsDatepickerModule, PaginationModule, ButtonsModule, 
   ModalModule } from 'ngx-bootstrap';
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
      PagenotfoundComponent
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
           whitelistedDomains: ['localhost:5000'],
           blacklistedRoutes: ['localhost:5000/api/auth']
         }
       }),
       ModalModule.forRoot()
   ],
   providers: [
      CommissionService,
      CommissionDetailResolver,
      AlertifyService,
      CommissionErrorListResolver,
      CarrierListResolver,
      ProductService,
      ProductListResolver,
      ActivityService,
      ActivityListResolver,
      StatusService,
      StatusListResolver,
      AuthService,
      ErrorInterceptorProvider,
      DecimalPipe,
      CurrencyPipe,
      ExcelService      
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
