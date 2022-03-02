import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceListURLComponent } from './service-list-url.component';

describe('ServiceListURLComponent', () => {
  let component: ServiceListURLComponent;
  let fixture: ComponentFixture<ServiceListURLComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServiceListURLComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ServiceListURLComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
