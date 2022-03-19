import { Component, OnInit} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-fund-transfer',
  templateUrl: './fund-transfer.component.html',
  styleUrls: ['./fund-transfer.component.css']
})
export class FundTransferComponent  {
  
  Beneficiaryinfo:FormGroup = this._bfi.group({
  beneficiaryname:['',[Validators.required]],
  beneficiaryaccountnumber:['',[Validators.required]],
  reenteraccountnumber:['',[Validators.required]],
  nickname:['']
})

IMPSpaymentinfo:FormGroup=this._imps.group({
  fromaccount:['',[Validators.required]],
  Toaccount:['',[Validators.required]],
  amount:['',[Validators.required]],
  recepientmobilenumber:['',[Validators.required]],
  transactiondate:['',[Validators.required]],
  maturityinstructions:['',[Validators.required]],
  remarks:['']
})
NEFTpaymentinfo:FormGroup=this._neft.group({
  fromaccount:['',[Validators.required]],
  Toaccount:['',[Validators.required]],
  amount:['',[Validators.required]],
  transactiondate:['',[Validators.required]],
  remarks:['']
})
RTGSpaymentinfo:FormGroup=this._rtgs.group({
  fromaccount:['',[Validators.required]],
  Toaccount:['',[Validators.required]],
  amount:['',[Validators.required]],
  transactiondate:['',[Validators.required]],
  remarks:['']
})
constructor(private _bfi:FormBuilder, 
           private _imps:FormBuilder,
           private _neft:FormBuilder,
           private _rtgs:FormBuilder){}

  

}
