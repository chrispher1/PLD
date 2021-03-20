import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
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
    // implementation using headers
    let header: HttpHeaders = new HttpHeaders();
    header = header.append('test1', '123');
    header = header.append('test2', 'trutty');
    header = header.append('sample', 'implementation using headers');
    
    return this.http.get<Product[]>(this.baseUrl + 'product',    
    {
      headers: header
    }

    );
  }
}
