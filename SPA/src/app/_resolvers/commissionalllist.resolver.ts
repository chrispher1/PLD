import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Commission } from '../_model/commission';
import { PaginatedResult } from '../_model/pagination';
import { CommissionService } from '../_service/commission.service';

@Injectable({
  providedIn: 'root'
})
export class CommissionAllListResolver implements Resolve<PaginatedResult<Commission[]>> {
  pageNumber = 1;
  pageSize = 10;
  constructor(private commissionService: CommissionService, private router: Router) {        
  }
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<PaginatedResult<Commission[]>> {
    return this.commissionService.getAll(this.pageNumber,this.pageSize).pipe(
      catchError( error => {
          console.log ( 'error loading commission all:' + error.message);
          this.router.navigate(['/commission']);          
          return of(null);
      })
    );
  }
}
