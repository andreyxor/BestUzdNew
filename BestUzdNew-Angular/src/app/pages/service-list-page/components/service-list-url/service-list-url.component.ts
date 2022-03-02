import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { ServiceItemData } from '../../service-item-data';
import { serviceItems } from '../../service-list.data';

@Component({
  selector: 'app-service-list-url',
  templateUrl: './service-list-url.component.html',
  styleUrls: ['./service-list-url.component.scss']
})
export class ServiceListURLComponent {
  public activeServices: { url?: string, title: string }[] = [];
  
  constructor(public router: Router) {
    const allAvailableServices: { title: string, url: string, parent?: ServiceItemData }[] = [];
    
    serviceItems.forEach(service => {
      allAvailableServices.push(service);
      service.childs.forEach(childService => allAvailableServices.push(childService));
    });
    
    router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        const currentUrls: string[] = event.url.split('/').map(x => decodeURI(x));
        currentUrls.shift(); // remove first one

        this.activeServices = [{ url: "/Послуги", title: 'Послуги' }];

        currentUrls.forEach(url => {
          const serviceEquivalent = allAvailableServices.find(service => service.url === url);
          if (serviceEquivalent) {
            const url = serviceEquivalent.parent ? `/${serviceEquivalent.parent.url}/${serviceEquivalent.url}` : `/Послуги/${serviceEquivalent.url}`;
            this.activeServices.push({ url, title: serviceEquivalent.title });
          } 
        });
      }
    })
  }

  public redirect(service: { url?: string, title: string }) {
    if (service.url) {
      this.router.navigateByUrl(service.url);
    }
  }
}
