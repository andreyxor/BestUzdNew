import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ChildServiceItemData } from '../../service-item-data';

@Component({
  selector: 'app-child-service-item',
  templateUrl: './child-service-item.component.html',
  styleUrls: ['./child-service-item.component.scss']
})
export class ChildServiceItemComponent implements OnInit {
  @Input()
  public data!: ChildServiceItemData;

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  public selectChildService() {
    // this.redirectToList([this.data.parent?.url || "not-found", this.data.url])
  }

  private redirectToList(subRoutes: string[] = []) {
    let route = '';
    if (subRoutes.length) route += `/${subRoutes.join('/')}`;
    this.router.navigateByUrl(route);
  }
}
