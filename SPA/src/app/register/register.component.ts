import { Component, OnInit, Output, EventEmitter, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserForRegisterDTO } from '../_model/userForRegisterDTO';
import { AuthService } from '../_service/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() registerMode = new EventEmitter();
  @ViewChild('r') registerForm: NgForm;  
 
  constructor(private autService: AuthService) { }

  ngOnInit() {
  }

  cancelRegister() {
    this.registerMode.emit(false);
  }

  registerSubmit() {        
    const registerObject: UserForRegisterDTO  = {
      FirstName : this.registerForm.value.firstName,
      LastName : this.registerForm.value.lastName,
      BirthDate : this.registerForm.value.birthDate,
      Username : this.registerForm.value.userName,
      Password : this.registerForm.value.password
    };
    
    this.autService.register(registerObject).subscribe(
      next => {         
      },
      error => {
        console.log (error);
      }
    );

  }
}
