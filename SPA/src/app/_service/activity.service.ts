import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Activity } from '../_model/activity';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {
baseUrl = environment.apiUrl;

constructor(private http: HttpClient) { }

getAllActivity(): Observable<Activity[]> {
  return this.http.get<Activity[]>(this.baseUrl + 'activity');
}
}
