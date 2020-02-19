import { Injectable } from "@angular/core";
import { Resolve, ActivatedRouteSnapshot } from "@angular/router";
import { Product } from "../_model/product";
import { Observable, of } from "rxjs";
import { HttpClient } from "selenium-webdriver/http";
import { ProductService } from "../_service/product.service";
import { catchError } from "rxjs/operators";

@Injectable()
export class ProductListResolver implements Resolve<Product[]> {
constructor (private productService: ProductService){}
    resolve(route: ActivatedRouteSnapshot): Observable<Product[]> {
        return this.productService.getAllProduct().pipe(
            catchError( error => {
                console.log( 'error loading product:' + error.message );
                return of(null);
            } 
                )
        );
    }
}