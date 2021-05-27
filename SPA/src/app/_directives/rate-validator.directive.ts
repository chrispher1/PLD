import { Directive, Input } from '@angular/core';
import { AbstractControl, NG_VALIDATORS, ValidationErrors, Validator } from '@angular/forms';

@Directive({
  selector: '[appRateValidator]',
  providers:[
    {
      provide:NG_VALIDATORS, useExisting:RateValidatorDirective, multi:true
    }
  ]
})
export class RateValidatorDirective implements Validator {
  @Input('MinimumRate') MinRate: number = 0;
  @Input('MaximumRate') MaxRate: number = 0;


  constructor() { }

  validate(control: AbstractControl): ValidationErrors | null {
    if ((control.value) &&
    ((+control.value < this.MinRate) || (+control.value > this.MaxRate)) ) {
      return { appRateValidator: true }
    }

    return null;
  }

}
