import { Directive } from '@angular/core';
import { Validator, AbstractControl, ValidationErrors, NG_VALIDATORS } from '@angular/forms';

@Directive({
  selector: '[appProductValidator]',
  providers: [
    { provide: NG_VALIDATORS, useExisting: ProductValidatorDirective,
      multi: true}
  ]
})
export class ProductValidatorDirective implements Validator {

  constructor() { }
  validate (control: AbstractControl): ValidationErrors | null{
    if (control.value === null){
      return { appProductValidator:true};
    }
    return null;
  }

}
