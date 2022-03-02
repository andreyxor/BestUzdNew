import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { ServiceItemData } from './service-item-data';
import { serviceItems } from './service-list.data';

@Component({
  selector: 'app-service-list-page',
  templateUrl: './service-list-page.component.html',
  styleUrls: ['./service-list-page.component.scss']
})
export class ServiceListPageComponent {
  serviceItems = serviceItems;
  selectService(service: ServiceItemData) {
    if (service.active) {
      this.redirectToRoute();
    } else {
      this.redirectToRoute([service.url]);
    }
  }

  constructor(private router: Router) { 
    router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        const urlParts = event.url.split('/').map(x => decodeURI(x));
        urlParts.shift(); // remove first one

        if (urlParts.length === 2) {
          this.activateServiceByUrl(urlParts[1]);
        } else if (urlParts.length === 1) {
          this.deactivateServices();
        }
      }
    })
  }

  private redirectToRoute(subRoutes: string[] = []) {
    let route = `/Послуги`;
    if (subRoutes.length) route += `/${subRoutes.join('/')}`;
    this.router.navigateByUrl(route);
  }

  private activateServiceByUrl(url: string) {
    this.deactivateServices();
    const item = this.serviceItems.find(x => x.url === url);
    item!.active = true;
  }

  private deactivateServices() {
    serviceItems.forEach(x => x.active = false);
  }
}
