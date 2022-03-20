import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Account } from '../../Models/Account';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-requested-account-details',
  templateUrl: './requested-account-details.component.html',
  styleUrls: ['./requested-account-details.component.css']
})
export class RequestedAccountDetailsComponent implements OnInit {

  constructor(private _as : AccountService, private route : ActivatedRoute ) { }
  Account? : Account
  
  ngOnInit(): void {

    const routeParams = this.route.snapshot.paramMap;
  const customerIdFromRoute = Number(routeParams.get('customerId'));
  const ObservableAccount : Observable<Account> = this._as.getAccountbyId(customerIdFromRoute)
  ObservableAccount.subscribe(
    (Accounts : Account) => this.Account = Accounts )
  }


}
