import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Status } from '../_model/status';
import { StatusService } from '../_service/status.service';

@Injectable({
  providedIn: 'root'
})
export class StatusListForCommissionFormResolver implements Resolve<Status[]> {
  constructor(private statusService: StatusService) {}
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Status[]> {
  return this.statusService.getStatusForCommissionForm().pipe(
      catchError ( error => {
        console.log( 'error loading status:' + error.message);
        return of(null);
      })
    );
    
  }
}
