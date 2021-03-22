import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { CommissionError } from '../_model/commissionError';
import { environment } from '../../environments/environment';
import { PaginatedResult } from '../_model/pagination';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CommissionService {
  baseUrl = environment.apiUrl;
  errorSubject: Subject<boolean> = new Subject<boolean>();

  constructor(private http: HttpClient) {
  }

  getAllError(page?, itemsPerPage?, commissionErrorSearchParam?): Observable<PaginatedResult<CommissionError[]>> {
    const paginatedResult: PaginatedResult<CommissionError[]> = new PaginatedResult<CommissionError[]>();
    let params = new HttpParams();

    if (page != null && itemsPerPage != null){
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }    
    
    if (commissionErrorSearchParam != null) {
      if (commissionErrorSearchParam.carrier != -1)
        params = params.append('CarrId', commissionErrorSearchParam.carrier);
      if (commissionErrorSearchParam.product != -1)
        params = params.append('ProdId', commissionErrorSearchParam.product);
      if (commissionErrorSearchParam.policyNumber != '')
        params = params.append('PolNum', commissionErrorSearchParam.policyNumber);
      if (commissionErrorSearchParam.policyYearMin != '')
        params = params.append('YrNumMin', commissionErrorSearchParam.policyYearMin);
      if (commissionErrorSearchParam.policyYearMax != '')
        params = params.append('YrNumMax', commissionErrorSearchParam.policyYearMax);
      if (commissionErrorSearchParam.activity != '-1')
        params = params.append('ActCd', commissionErrorSearchParam.activity);        
      if (commissionErrorSearchParam.grossPremiumAmountMin != '')
        params = params.append('GrsPremAmtMin', commissionErrorSearchParam.grossPremiumAmountMin);        
      if (commissionErrorSearchParam.grossPremiumAmountMax != '')
        params = params.append('GrsPremAmtMax', commissionErrorSearchParam.grossPremiumAmountMax);
      if (commissionErrorSearchParam.commissionPremiumAmountMin != '')
        params = params.append('CommPremAmtMin', commissionErrorSearchParam.commissionPremiumAmountMin);
      if (commissionErrorSearchParam.commissionPremiumAmountMax != '')
        params = params.append('CommPremAmtMax', commissionErrorSearchParam.commissionPremiumAmountMax);
      if (commissionErrorSearchParam.commissionRateMin != '')
        params = params.append('CommRateMin', commissionErrorSearchParam.commissionRateMin);
      if (commissionErrorSearchParam.commissionRateMax != '')
        params = params.append('CommRateMax', commissionErrorSearchParam.commissionRateMax);
      if (commissionErrorSearchParam.commissionAmountMin != '')
        params = params.append('CommAmtMin', commissionErrorSearchParam.commissionAmountMin);
      if (commissionErrorSearchParam.commissionAmountMax != '')
        params = params.append('CommAmtMax', commissionErrorSearchParam.commissionAmountMax);
      if (commissionErrorSearchParam.status != '-1')
        params = params.append('StatCd', commissionErrorSearchParam.status);
      }
    
    return this.http.get<CommissionError[]>( this.baseUrl + 'commissionerror', { observe: 'response', params})
    .pipe(
      map( respons => {
        paginatedResult.result  = respons.body;
        paginatedResult.pagination = JSON.parse( respons.headers.get('Pagination') );
        return paginatedResult;
      })
    );

  }

  getErrordByID(id: number): Observable<CommissionError> {
    return this.http.get<CommissionError>(this.baseUrl + 'commissionerror/getrecord/' + id);    
  }

  updateError( commissionError: CommissionError) {        
    return this.http.put(this.baseUrl + 'commissionerror/updaterecord', commissionError );    
  }
  addError( commissionError: CommissionError) {
    return this.http.post(this.baseUrl + 'commissionError/addrecord', commissionError);
  }
  deleteError( commissionError: CommissionError){
    return this.http.delete( this.baseUrl + 'commissionError/deleterecord/' + commissionError.commId);
  }
  deleteMultiError( commissionErrorList: CommissionError[] ) {    
    let data = {
      "commissionErrorList": commissionErrorList
    }    
    return this.http.post( this.baseUrl + 'commissionError/deletemultirecord' , data);
  }
}
 