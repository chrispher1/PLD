import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Status } from '../_model/status';

@Injectable({
  providedIn: 'root'
})
export class StatusService {
baseUrl = environment.apiUrl;
constructor(private http: HttpClient) { }

getAllStatus(): Observable<Status[]> {
 return this.http.get<Status[]>(this.baseUrl + 'status');
}

getStatusForCommissionForm(): Observable<Status[]> {
  return this.http.get<Status[]>(this.baseUrl + 'status/forCommissionForm/P');
 }

}
