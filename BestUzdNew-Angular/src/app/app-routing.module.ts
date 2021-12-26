import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./pages/home-page/home-page.module').then(x => x.HomePageModule)
  },
  {
    path: 'контакти',
    loadChildren: () => import('./pages/contacts-page/contacts-page.module').then(x => x.ContactsPageModule)
  },
  {
    path: 'сервисы',
    loadChildren: () => import('./pages/service-list-page/service-list-page.module').then(x => x.ServiceListPageModule)
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
