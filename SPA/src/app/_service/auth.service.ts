import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import { JwtHelperService} from '@auth0/angular-jwt';
import { User } from '../_model/user';
import { environment } from 'src/environments/environment';
import { UserForLoginDTO } from '../_model/UserForLoginDTO';
import { UserForRegisterDTO } from '../_model/userForRegisterDTO';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = environment.apiUrl;
  jwtHelper = new JwtHelperService();

constructor(private http: HttpClient, private router: Router) { }

register(userForRegisterDTO: UserForRegisterDTO) {
  return this.http.post( this.baseUrl + 'auth/register', userForRegisterDTO).pipe(
    tap( (responseFromAPI: any) => {
      if (responseFromAPI) {
        localStorage.setItem('token', responseFromAPI.token);
        localStorage.setItem('userName', responseFromAPI.user.username);
      }
      return;
    })
  )
  ;
}

login ( userForLoginDTO: UserForLoginDTO ) { 
  let params = new HttpParams();
    params = params.append('Username', userForLoginDTO.Username);
    params = params.append('Password', userForLoginDTO.Password);

  return this.http.get(this.baseUrl + 'auth/login',
    {
      params: params
    }).pipe(
          map( (response: any) => {
            const responseFromAPI = response;
            if (responseFromAPI) {
              localStorage.setItem('token', responseFromAPI.token);
              localStorage.setItem('userName', responseFromAPI.user.username);
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
