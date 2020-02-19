/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CommissiondetailComponent } from './commissiondetail.component';

describe('CommissiondetailComponent', () => {
  let component: CommissiondetailComponent;
  let fixture: ComponentFixture<CommissiondetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CommissiondetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CommissiondetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
