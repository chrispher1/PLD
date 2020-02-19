import { Directive, OnInit, ElementRef, HostListener, Input, ViewChild } from '@angular/core';
import { CurrencyPipe } from '../_pipe/currency.pipe';

@Directive({
  selector: '[appCurrency]'
})
export class CurrencyDirective implements OnInit {
  private el: any;  
  @Input('numericType') numericType: string; // number | decimal  
  private regex = {
    number: new RegExp(/^\d+$/),
    decimal: new RegExp(/^[0-9]+(\.[0-9]*){0,1}$/g)
  };
  private specialKeys = {
      number: [ 'Delete', 'Backspace', 'Tab', 'End', 'Home', 'ArrowLeft', 'ArrowRight' ],
      decimal: [ 'Delete', 'Backspace', 'Tab', 'End', 'Home', 'ArrowLeft', 'ArrowRight' ],
  };
  
  constructor(
    private elementRef: ElementRef,
    private formatcurrencypipe: CurrencyPipe
  ){ 
    this.el = this.elementRef.nativeElement;
  }

  ngOnInit(){             
    //this.el.value = this.formatcurrencypipe.transform(this.initialvalue);
    //console.log('this.el.value:' + this.el.value);
  }

  @HostListener('focus',['$event.target.value','$event'])
  onFocus(value,event) {    
    this.el.value = this.formatcurrencypipe.parse(value); // opossite of transform
    if ( event.which === 9)
    {
        return false;
    }
    this.el.select();
    
  }

  @HostListener('blur', ['$event.target.value'])
  onBlur(value) {
    this.el.value = this.formatcurrencypipe.transform(value);
  }

  @HostListener('keydown', [ '$event' ])
    onKeyDown(event: KeyboardEvent) {

        if (this.specialKeys[this.numericType].indexOf(event.key) !== -1) {
            return;
        }
        // Do not use event.keycode this is deprecated.
        // See: https://developer.mozilla.org/en-US/docs/Web/API/KeyboardEvent/keyCode
        let current: string = this.el.value;
        let next: string = current.concat(event.key);
        if (next && !String(next).match(this.regex[this.numericType])) {
            event.preventDefault();
        }
    }    
}
