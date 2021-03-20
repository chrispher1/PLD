import { Routes } from '@angular/router';

import { CaseComponent } from './case/case.component';
import { CommissionComponent } from './commission/commission.component';
import { PaymentComponent } from './payment/payment.component';
import { CommissionDetailComponent } from './commission/commissiondetail/commissiondetail.component';
import { HomeComponent } from './home/home.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';

import {CommissionDetailResolver} from './_resolvers/commissiondetailresolver';
import { CommissionErrorListResolver } from './_resolvers/commissionerrorlistresolver';
import { CarrierListResolver } from './_resolvers/carrierlistresolver';
import { ProductListResolver } from './_resolvers/productlistresolver';
import { ActivityListResolver } from './_resolvers/activitylistresolver';
import { StatusListResolver } from './_resolvers/statuslistresolver';
import { ProductComponent } from './product/product.component';
import { RateComponent } from './rate/rate.component';
import { TransactionTypeComponent } from './transactiontype/transactiontype.component';

export const routes: Routes = [

    { path: '', redirectTo:'/home', pathMatch: 'full'},
    { path: 'home', component: HomeComponent},
    { path: 'commission' , component: CommissionComponent,
            resolve: { commissionError: CommissionErrorListResolver, carrier: CarrierListResolver, 
                      product: ProductListResolver, activity: ActivityListResolver,
                      status: StatusListResolver} ,
                      children: [                        
                          { path: 'commissiondetail', component: CommissionDetailComponent , 
                          resolve: {commissionError: CommissionDetailResolver, carrier: CarrierListResolver}
                          }
                        ]
                    },
    { path: 'payment', component: PaymentComponent},
    { path: 'case', component: CaseComponent},
    { path: 'product', component: ProductComponent},
    { path: 'rate', component: RateComponent},
    { path: 'transactiontype', component: TransactionTypeComponent},
    { path: 'pagenotfound', component: PagenotfoundComponent},
    { path: '**', redirectTo: '/pagenotfound', pathMatch: 'full' }
];


