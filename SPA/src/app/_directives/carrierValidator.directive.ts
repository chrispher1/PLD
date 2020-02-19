import { Directive } from '@angular/core';
import { Validator, AbstractControl, ValidationErrors, NG_VALIDATORS } from '@angular/forms';

@Directive({
  selector: '[appCarrierValidator]',
  providers: [
     { provide: NG_VALIDATORS, useExisting: CarrierValidatorDirective, multi: true }
  ]
})
export class CarrierValidatorDirective implements Validator{

  constructor() { }

  validate(control: AbstractControl): ValidationErrors | null {    
    if (control.value === null) {
      return {appCarrierValidator: true};
    }
    return null;
  }

}
