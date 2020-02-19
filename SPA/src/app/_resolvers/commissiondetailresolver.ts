import {Injectable} from '@angular/core';
import {CommissionError} from '../_model/commissionError';
import {Resolve, Router, ActivatedRouteSnapshot} from '@angular/router';
import {CommissionService} from '../_service/commission.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class CommissionDetailResolver implements Resolve<CommissionError> {
    constructor(private commissionService: CommissionService, private router: Router){

    }
    resolve(route: ActivatedRouteSnapshot): Observable<CommissionError> {
        return this.commissionService.getErrordByID(route.params['id']).pipe(
            catchError(error => {  
                console.log ( 'error loading commissiondetail:' + error.message);              
                this.router.navigate(['/commission']);
                return of(null);
            })
        );
    }
}
