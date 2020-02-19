import { Directive } from '@angular/core';
import { Validator, AbstractControl, ValidationErrors, NG_VALIDATORS } from '@angular/forms';

@Directive({
  selector: '[appStatusValidator]',
  providers: [
    { provide: NG_VALIDATORS, useExisting: StatusValidatorDirective, multi: true}
  ]
})
export class StatusValidatorDirective implements Validator {

  constructor() { }

  validate(control: AbstractControl): ValidationErrors | null {
    if (control.value === null) {
      return { appStatusValidator: true};
    }
    return null;
  }

  }


