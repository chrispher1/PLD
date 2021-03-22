import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable, of } from "rxjs";
import { root } from 'rxjs/internal-compatibility';
import { catchError } from 'rxjs/operators';
import { Carrier } from '../_model/carrier';
import { CarrierService } from '../_service/carrier.service';

@Injectable({ 
    providedIn: 'root'
})
export class CarrierListResolver implements Resolve<Carrier[]> {
    constructor(private carrierService: CarrierService, private router: Router) {
    }

    resolve( route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Carrier[]> {
        return this.carrierService.getAllCarrier().pipe(
            catchError( error =>  {
                console.log ( 'error loading carrier:' + error.message);
                return of(null);
                        }                
                )
        );
    }
}