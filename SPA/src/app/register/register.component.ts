import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() registerMode = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }

  cancelRegister() {
    this.registerMode.emit(false);
  }
}
