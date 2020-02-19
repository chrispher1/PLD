import {Routes} from '@angular/router';

import {CaseComponent} from './case/case.component';
import {CommissionComponent} from './commission/commission.component';
import {PaymentComponent} from './payment/payment.component';
import {CommissionDetailComponent} from './commission/commissiondetail/commissiondetail.component';

import {CommissionDetailResolver} from './_resolvers/commissiondetailresolver';
import { CommissionErrorListResolver } from './_resolvers/commissionerrorlistresolver';
import { CarrierListResolver } from './_resolvers/carrierlistresolver';
import { ProductListResolver } from './_resolvers/productlistresolver';
import { ActivityListResolver } from './_resolvers/activitylistresolver';
import { StatusListResolver } from './_resolvers/statuslistresolver';
import { HomeComponent } from './home/home.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
export const routes: Routes = [
  {  
  path: '',
  children: [
  {path: 'home', component: HomeComponent},
  {path: 'commission', component: CommissionComponent,
    resolve:{ commissionError: CommissionErrorListResolver, carrier: CarrierListResolver, 
      product: ProductListResolver, activity: ActivityListResolver,
      status: StatusListResolver}
  },
  {path: 'commissiondetail', component: CommissionDetailComponent , 
    resolve: {commissionError: CommissionDetailResolver, carrier: CarrierListResolver}
  },
  {path: 'payment', component: PaymentComponent},
  { path: 'case', component: CaseComponent},
  { path: 'pagenotfound', component: PagenotfoundComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full'}
  ,
  {path: '**', redirectTo: '/pagenotfound', pathMatch: 'full'} 
  ]
}
];


