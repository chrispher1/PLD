import { Directive } from '@angular/core';
import { Validator, ValidationErrors, AbstractControl, NG_VALIDATORS } from '@angular/forms';

@Directive({
  selector: '[appPolicyNumberValidator]',
  providers: [
    {
      provide: NG_VALIDATORS, useExisting: PolicyNumberValidatorDirective, multi: true
    }
  ]
})
export class PolicyNumberValidatorDirective implements Validator {

  constructor() { }

  validate(control: AbstractControl): ValidationErrors | null {    
    if (control.value === 'pol1') {
      return { appPolicyNumberValidator: true };
    }
    return null;
  }

}
