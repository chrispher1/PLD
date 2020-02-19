import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Product } from '../_model/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
baseUrl = environment.apiUrl;
constructor(private http: HttpClient) { }

  getAllProduct(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl + 'product');
  }
}
