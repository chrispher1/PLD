import { Component, OnInit, Output, EventEmitter, ViewChild, OnDestroy } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Subscription } from 'rxjs';
import { AuthService } from '../_service/auth.service';
import { AlertifyService } from '../_service/alertify.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {
  @ViewChild('l') loginForm: NgForm;
  loginObject = { Username: '',
    Password: ''
  };
  @Output() registerMode = new EventEmitter();
  loginSubscription: Subscription;
  
  constructor(private authService: AuthService, private alertifyservice: AlertifyService) { }

  ngOnInit() {
  }

  ngOnDestroy() {
    if (this.loginSubscription) {
      this.loginSubscription.unsubscribe();
    }
  }

  loginSubmit() {
    this.loginObject.Username = this.loginForm.value.username;
    this.loginObject.Password = this.loginForm.value.password;

    this.loginSubscription = this.authService.login(this.loginObject).subscribe(
        next => {},
        error => {
          this.alertifyservice.error(error);
        }
      );
  }

  toggleregister() {
    this.registerMode.emit(true);
  }

}
