import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessagedetailComponent } from './messagedetail.component';

describe('MessagedetailComponent', () => {
  let component: MessagedetailComponent;
  let fixture: ComponentFixture<MessagedetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MessagedetailComponent]
    });
    fixture = TestBed.createComponent(MessagedetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
