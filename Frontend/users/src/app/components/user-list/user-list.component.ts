import { Component } from '@angular/core';
import { UserService } from '../../services/user.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-userlist',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserlistComponent {
  users: Observable<any[]> = new Observable<any[]>;

  constructor(private userService: UserService) {}

  ngOnInit(): void {
    this.users = this.userService.getUsers();
  }
}
