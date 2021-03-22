import { Injectable } from "@angular/core";
import { Resolve, Router, ActivatedRouteSnapshot } from "@angular/router";
import { PaginatedResult } from "../_model/pagination";
import { CommissionError } from "../_model/commissionError";
import { CommissionService } from "../_service/commission.service";
import { catchError } from "rxjs/operators";
import { of, Observable } from "rxjs";


@Injectable()
export class CommissionErrorListResolver implements Resolve<PaginatedResult<CommissionError[]>> {
    pageNumber = 1;
    pageSize = 10;

    constructor( private commissionService: CommissionService , private router: Router) {
    }
    resolve(route: ActivatedRouteSnapshot): Observable<PaginatedResult<CommissionError[]>> {
        
        return this.commissionService.getAllError(this.pageNumber, this.pageSize).pipe(
            catchError(error => {
                console.log ( 'error loading commissionerrordetail:' + error.message);
                this.router.navigate(['/commission']);
                return of(null);
            })
        );            
    }
}
