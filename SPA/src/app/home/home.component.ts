import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_service/auth.service';
import { AlertifyService } from '../_service/alertify.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  toggleRegister = false;
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  currentlyLogged () {
    return this.authService.currentlyLogged();
  }
  
  registerMode(registerMode: boolean) {    
    this.toggleRegister = registerMode;    
  }

}
