import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../_service/auth.service';
import { AlertifyService } from '../_service/alertify.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginObject: any = {};
  @Output() registerMode = new EventEmitter();

  constructor(private authService: AuthService, private alertifyservice: AlertifyService) { }

  ngOnInit() {
    this.loginObject.Username = '';
    this.loginObject.Password = '';
  }

  loginSubmit() {
    this.authService.login(this.loginObject).subscribe(
      next => {},
      error => { this.alertifyservice.error(error); }
    );    
  }

  toggleregister() {
    this.registerMode.emit(true);
  }
  
}
