import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientdetailComponent } from './clientdetail.component';

describe('ClientdetailComponent', () => {
  let component: ClientdetailComponent;
  let fixture: ComponentFixture<ClientdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClientdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClientdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
