import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../_model/user';
import { environment } from 'src/environments/environment';
import { UserForLoginDTO } from '../_model/UserForLoginDTO';
import { map } from 'rxjs/operators';
import { JwtHelperService} from '@auth0/angular-jwt';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})

export class AuthService {
  baseUrl = environment.apiUrl;
  jwtHelper = new JwtHelperService();

constructor(private http: HttpClient, private router: Router) { }

login ( userForLoginDTO: UserForLoginDTO ) { 
  return this.http.post(this.baseUrl + 'auth/login', userForLoginDTO)
          .pipe(
          map( (response: any) => {    
            const responseFromAPI = response;
            if (responseFromAPI)
            {
              localStorage.setItem('token', responseFromAPI.token);
              localStorage.setItem('userName', responseFromAPI.user.username);              
              this.router.navigate(['/commission']);
            }                
            return;
          })
          );
    }

  currentlyLogged() {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }

  logoff() {
    localStorage.removeItem('token');
    localStorage.removeItem('userName');
    this.router.navigate(['/home']);
  }

}
