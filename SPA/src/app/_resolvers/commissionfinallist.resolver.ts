import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { CommissionFinal } from '../_model/commissionFinal';
import { PaginatedResult } from '../_model/pagination';
import { CommissionService } from '../_service/commission.service';

@Injectable({
  providedIn: 'root'
})
export class CommissionFinalListResolver implements Resolve<PaginatedResult<CommissionFinal[]>> {
  pageNumber = 1;
  pageSize = 10;

  constructor( private commissionService: CommissionService , private router: Router) {
  }
  
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<PaginatedResult<CommissionFinal[]>> {
    return this.commissionService.getAllFinal(this.pageNumber, this.pageSize).pipe(
      catchError(error => {
          console.log ( 'error loading commissionfinal:' + error.message);
          this.router.navigate(['/commission']);
          return of(null);
      })
  );  
  }
}
