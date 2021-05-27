import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { CommissionError } from '../_model/commissionError';
import { environment } from '../../environments/environment';
import { PaginatedResult } from '../_model/pagination';
import { map } from 'rxjs/operators';
import { CommissionFinal } from '../_model/commissionFinal';
import { Commission } from '../_model/commission';

@Injectable({
  providedIn: 'root'
})
export class CommissionService {
  baseUrl = environment.apiUrl;
  commissionSubject: Subject<boolean> = new Subject<boolean>();

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
    
    return this.http.get<CommissionError[]>( this.baseUrl + 'commission/error', { observe: 'response', params})
    .pipe(
      map( respons => {
        paginatedResult.result  = respons.body;
        paginatedResult.pagination = JSON.parse( respons.headers.get('Pagination') );
        return paginatedResult;
      })
    );

  }

  getAllFinal(page?, itemsPerPage?, commissionFinalSearchParam?): Observable<PaginatedResult<CommissionFinal[]>> {
  const paginatedResult: PaginatedResult<CommissionFinal[]> = new PaginatedResult<CommissionFinal[]>();
  let params = new HttpParams();

  if (page != null && itemsPerPage != null){
    params = params.append('pageNumber', page);
    params = params.append('pageSize', itemsPerPage);
  }    
  
  if (commissionFinalSearchParam != null) {
    if (commissionFinalSearchParam.carrier != -1)
      params = params.append('CarrId', commissionFinalSearchParam.carrier);
    if (commissionFinalSearchParam.product != -1)
      params = params.append('ProdId', commissionFinalSearchParam.product);
    if (commissionFinalSearchParam.policyNumber != '')
      params = params.append('PolNum', commissionFinalSearchParam.policyNumber);
    if (commissionFinalSearchParam.policyYearMin != '')
      params = params.append('YrNumMin', commissionFinalSearchParam.policyYearMin);
    if (commissionFinalSearchParam.policyYearMax != '')
      params = params.append('YrNumMax', commissionFinalSearchParam.policyYearMax);
    if (commissionFinalSearchParam.activity != '-1')
      params = params.append('ActCd', commissionFinalSearchParam.activity);        
    if (commissionFinalSearchParam.grossPremiumAmountMin != '')
      params = params.append('GrsPremAmtMin', commissionFinalSearchParam.grossPremiumAmountMin);        
    if (commissionFinalSearchParam.grossPremiumAmountMax != '')
      params = params.append('GrsPremAmtMax', commissionFinalSearchParam.grossPremiumAmountMax);
    if (commissionFinalSearchParam.commissionPremiumAmountMin != '')
      params = params.append('CommPremAmtMin', commissionFinalSearchParam.commissionPremiumAmountMin);
    if (commissionFinalSearchParam.commissionPremiumAmountMax != '')
      params = params.append('CommPremAmtMax', commissionFinalSearchParam.commissionPremiumAmountMax);
    if (commissionFinalSearchParam.commissionRateMin != '')
      params = params.append('CommRateMin', commissionFinalSearchParam.commissionRateMin);
    if (commissionFinalSearchParam.commissionRateMax != '')
      params = params.append('CommRateMax', commissionFinalSearchParam.commissionRateMax);
    if (commissionFinalSearchParam.commissionAmountMin != '')
      params = params.append('CommAmtMin', commissionFinalSearchParam.commissionAmountMin);
    if (commissionFinalSearchParam.commissionAmountMax != '')
      params = params.append('CommAmtMax', commissionFinalSearchParam.commissionAmountMax);
    if (commissionFinalSearchParam.status != '-1')
      params = params.append('StatCd', commissionFinalSearchParam.status);
    }
  
  return this.http.get<CommissionFinal[]>( this.baseUrl + 'commission/final', { observe: 'response', params})
  .pipe(
    map( respons => {
      paginatedResult.result  = respons.body;
      paginatedResult.pagination = JSON.parse( respons.headers.get('Pagination') );
      return paginatedResult;
    })
  );
}

getAll(page?, itemsPerPage?, commissionSearchParam?): Observable<PaginatedResult<Commission[]>> {
  const paginatedResult: PaginatedResult<Commission[]> = new PaginatedResult<Commission[]>();
  let params = new HttpParams();

  if (page != null && itemsPerPage != null){
    params = params.append('pageNumber', page);
    params = params.append('pageSize', itemsPerPage);
  }    
  
  if (commissionSearchParam != null) {
    if (commissionSearchParam.carrier != -1)
      params = params.append('CarrId', commissionSearchParam.carrier);
    if (commissionSearchParam.product != -1)
      params = params.append('ProdId', commissionSearchParam.product);
    if (commissionSearchParam.policyNumber != '')
      params = params.append('PolNum', commissionSearchParam.policyNumber);
    if (commissionSearchParam.policyYearMin != '')
      params = params.append('YrNumMin', commissionSearchParam.policyYearMin);
    if (commissionSearchParam.policyYearMax != '')
      params = params.append('YrNumMax', commissionSearchParam.policyYearMax);
    if (commissionSearchParam.activity != '-1')
      params = params.append('ActCd', commissionSearchParam.activity);        
    if (commissionSearchParam.grossPremiumAmountMin != '')
      params = params.append('GrsPremAmtMin', commissionSearchParam.grossPremiumAmountMin);        
    if (commissionSearchParam.grossPremiumAmountMax != '')
      params = params.append('GrsPremAmtMax', commissionSearchParam.grossPremiumAmountMax);
    if (commissionSearchParam.commissionPremiumAmountMin != '')
      params = params.append('CommPremAmtMin', commissionSearchParam.commissionPremiumAmountMin);
    if (commissionSearchParam.commissionPremiumAmountMax != '')
      params = params.append('CommPremAmtMax', commissionSearchParam.commissionPremiumAmountMax);
    if (commissionSearchParam.commissionRateMin != '')
      params = params.append('CommRateMin', commissionSearchParam.commissionRateMin);
    if (commissionSearchParam.commissionRateMax != '')
      params = params.append('CommRateMax', commissionSearchParam.commissionRateMax);
    if (commissionSearchParam.commissionAmountMin != '')
      params = params.append('CommAmtMin', commissionSearchParam.commissionAmountMin);
    if (commissionSearchParam.commissionAmountMax != '')
      params = params.append('CommAmtMax', commissionSearchParam.commissionAmountMax);
    if (commissionSearchParam.status != '-1')
      params = params.append('StatCd', commissionSearchParam.status);
    }
  
  return this.http.get<Commission[]>( this.baseUrl + 'commission/all', { observe: 'response', params})
  .pipe(
    map( respons => {
      paginatedResult.result  = respons.body;
      paginatedResult.pagination = JSON.parse( respons.headers.get('Pagination') );
      return paginatedResult;
    })
  );
}

  getErrordByID(id: number): Observable<CommissionError> {
    return this.http.get<CommissionError>(this.baseUrl + 'commission/error/getrecord/' + id);    
  }

  getFinaldByID(id: number): Observable<CommissionFinal> {
    return this.http.get<CommissionFinal>(this.baseUrl + 'commission/final/getrecord/' + id);    
  }

  updateError( commission: CommissionError) {        
    return this.http.put(this.baseUrl + 'commission/error/updaterecord', commission );    
  }

  updateFinal( commission: CommissionFinal) {        
    return this.http.put(this.baseUrl + 'commission/final/updaterecord', commission );    
  }

  revalidateFinal( commission: CommissionFinal) {        
    return this.http.post(this.baseUrl + 'commission/final/revalidaterecord', commission );    
  }

  revalidateMultiFinal( commissionIdList: number[] ) {       
    return this.http.post( this.baseUrl + 'commission/final/revalidatemultirecord' , commissionIdList);
  }

  processError( commission: CommissionError) {
    return this.http.post(this.baseUrl + 'commission/error/processrecord', commission);
  }
  
  addError( commission: CommissionError) {
    return this.http.post(this.baseUrl + 'commission/error/addrecord', commission);
  }
  deleteError( commId: number) {
    return this.http.delete( this.baseUrl + 'commission/error/deleterecord/' + commId);
  }
  deleteMultiError( commissionIdList: number[] ) {       
    return this.http.put( this.baseUrl + 'commission/error/deletemultirecord' , commissionIdList);
  }
}
 