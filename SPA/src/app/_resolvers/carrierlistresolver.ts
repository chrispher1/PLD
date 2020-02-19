import { Injectable } from "@angular/core";
import { Resolve, Router, ActivatedRouteSnapshot } from "@angular/router";
import { Carrier } from "../_model/carrier";
import { CarrierService } from "../_service/carrier.service";
import { Observable, of } from "rxjs";
import { catchError } from "rxjs/operators";

@Injectable()
export class CarrierListResolver implements Resolve<Carrier[]> {
    constructor(private carrierService: CarrierService, private router: Router) {

    }

    resolve( route: ActivatedRouteSnapshot): Observable<Carrier[]> {
        return this.carrierService.getAllCarrier().pipe(
            catchError( error =>  {
                console.log ( 'error loading carrier:' + error.message);
                return of(null);
                        }              
                
                )
        );
    }
}