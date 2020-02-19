import { Injectable } from "@angular/core";
import { Resolve, ActivatedRouteSnapshot } from "@angular/router";
import { Observable, of } from "rxjs";
import { Activity } from "../_model/activity";
import { ActivityService } from "../_service/activity.service";
import { catchError } from "rxjs/operators";

@Injectable()
export class ActivityListResolver implements Resolve<Activity[]> {
    constructor(private activityservice: ActivityService){}

    resolve(route: ActivatedRouteSnapshot): Observable<Activity[]> {
    return this.activityservice.getAllActivity().pipe(
            catchError( error =>
                {
                    console.log ('error loading activity' + error.message);
                    return of(null);
                }

            )
        );
    }

}