
import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';
import { Account } from '../Models/Account';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent  implements OnInit{




  Accounts? : Account[]  
  constructor(private _as : AccountService) { }

  ngOnInit(): void {

    const ObservableAccount : Observable<Account[]> = this._as.getAllaccount()
    ObservableAccount.subscribe(
      (Accounts : Account[]) => this.Accounts = Accounts
    )

  }

}
