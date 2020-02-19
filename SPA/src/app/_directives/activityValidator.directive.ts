import { Directive } from '@angular/core';
import { Validator, AbstractControl, ValidationErrors, NG_VALIDATORS } from '@angular/forms';

@Directive({
  selector: '[appActivityValidator]',
  providers: [
    { provide: NG_VALIDATORS, useExisting: ActivityValidatorDirective,
      multi: true}
  ]
})
export class ActivityValidatorDirective implements Validator {

  constructor() { }

  validate(control: AbstractControl ): ValidationErrors | null {
    if (control.value === null) {
      return { appActivityValidator: true};
    }
    return null;
  }

}
