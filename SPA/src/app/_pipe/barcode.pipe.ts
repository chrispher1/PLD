import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'barcode'  
})
export class BarcodePipe implements PipeTransform {

  transform(value: any, args?: any): any {
    if (!value) {
      return '';
  }
  return '****-****_' + (value.length > 8 ? ' more than 8' : ' less than 8');
}
}
