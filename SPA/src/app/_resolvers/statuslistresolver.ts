import { Injectable } from "@angular/core";
import { Resolve, ActivatedRouteSnapshot } from "@angular/router";
import { Status } from "../_model/status";
import { StatusService } from "../_service/status.service";
import { Observable, of } from "rxjs";
import { catchError } from "rxjs/operators";

@Injectable()
export class StatusListResolver implements Resolve<Status[]> {
    constructor (private statusService: StatusService){}
    resolve(route: ActivatedRouteSnapshot): Observable<Status[]> {
        return this.statusService.getAllStatus().pipe(
            catchError( error => {
                console.log( 'error loading status:' + error.message);
                return of(null);
            }) 
        );
    }

}