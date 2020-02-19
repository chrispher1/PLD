import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { Carrier } from '../_model/carrier';

@Injectable({
  providedIn: 'root'
})
export class CarrierService {
  baseUrl = environment.apiUrl;

constructor(private http: HttpClient) { 
}

getAllCarrier(): Observable<Carrier[]>{
  return this.http.get<Carrier[]>(this.baseUrl + 'carrier');
}

}
