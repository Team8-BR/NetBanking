import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { ResponseModel } from '../Models/ResponseModel';
import { Transaction } from '../Models/Transaction';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private url = "http://localhost:17255/api/Transaction"
  constructor(private _http : HttpClient) { }

  
  getAllTransaction () : Observable<Transaction[]> 
  {

    const responseObject = this._http.get(this.url);
// response from the get is in type Object 

   const mappedObservable : Observable<Transaction[]> = responseObject
        .pipe(map(array =>  <Transaction[]>array)) ;
    return mappedObservable 
 }

 getTransactionbyId(id : number) : Observable<Transaction> {

   const responseObject = this._http.get(`${this.url}/${id}`)
   const mappedObservableTransaction : Observable<Transaction> = responseObject.pipe(map(a => <Transaction>a));
   return mappedObservableTransaction
 } 

 addTransaction(Transaction : Transaction ): Observable<ResponseModel> {
   const responseObject = this._http.post(`${this.url}`, Transaction)
   return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
 }

 updateTransaction(Transaction : Transaction): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, Transaction)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}

deleteTransaction(id : number): Observable<ResponseModel> {
  const responseObject = this._http.put(`${this.url}`, id)
  return responseObject.pipe(map((response: any) => <ResponseModel>response)) 
}

}
