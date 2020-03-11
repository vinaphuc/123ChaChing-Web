﻿'use strict';
/** 
  * controller for v-accordion
  * AngularJS multi-level accordion component.
*/
(function (angular) {
    app.controller('responseRebuttalvAccordionCtrl', ["$scope", "$uibModal", function ($scope, $uibModal) {
        $scope.firstAccordionControl = {
            onExpand: function (expandedPaneIndex) {
                console.log('expanded:', expandedPaneIndex);
            },
            onCollapse: function (collapsedPaneIndex) {
                console.log('collapsed:', collapsedPaneIndex);
            }
        };
        $scope.panes = [{
            header: 'Tôi không có tiền - Tiêu đề 1',
            content: 'Tôi hoàn toàn hiểu điều này. Tôi có một người bạn đã phải dành tất cả số tiền tiết kiệm trong tài khoản để sử dụng 123 ChaChing. Hiện giờ anh ấy có một căn hộ sang trọng và một công việc kinh doanh của anh ấy đang phát triển hằng ngày. Bạn có thể dành ra ngay 20.000 một ngày?'
        }, {
            header: 'Tôi không có tiền - Tiêu đề 2',
            content: 'Tôi hoàn toàn hiểu điều này. Tôi có một người bạn đã phải dành tất cả số tiền tiết kiệm trong tài khoản để sử dụng 123 ChaChing. Hiện giờ anh ấy có một căn hộ sang trọng và một công việc kinh doanh của anh ấy đang phát triển hằng ngày. Bạn có thể dành ra ngay 20.000 một ngày?'
        }, {
            header: 'Tôi không có tiền - Tiêu đề 3',
            content: 'Tôi hoàn toàn hiểu điều này. Tôi có một người bạn đã phải dành tất cả số tiền tiết kiệm trong tài khoản để sử dụng 123 ChaChing. Hiện giờ anh ấy có một căn hộ sang trọng và một công việc kinh doanh của anh ấy đang phát triển hằng ngày. Bạn có thể dành ra ngay 20.000 một ngày?'
        }];

        $scope.updateRebuttalContent = function (size) {
            var modalInstance = $uibModal.open({
                templateUrl: 'myModalupdateRebuttalContent.html',
                controller: 'ModalUpdateRebuttalContentCtrl',
                size: size,
                resolve: {
                    items: function () {
                        return $scope.items;
                    }
                }
            });
        };
    }]);
})(angular);

app.controller('ModalUpdateRebuttalContentCtrl', ["$scope", "$window", "$location", "$timeout", "$localStorage", "$uibModalInstance", "items", "leadService", "membershipService", "notificationService",
    function ($scope, $window, $location, $timeout, $localStorage, $uibModalInstance, items, leadService, membershipService, notificationService) {
        $scope.leads = {};

        $scope.ok = function () {

        };

        $scope.showSpinner = false;
        $scope.form = {
            submit: function (form) {
                var firstError = null;
                if (form.$invalid) {

                    var field = null, firstError = null;
                    for (field in form) {
                        if (field[0] != '$') {
                            if (firstError === null && !form[field].$valid) {
                                firstError = form[field].$name;
                            }

                            if (form[field].$pristine) {
                                form[field].$dirty = true;
                            }
                        }
                    }

                    angular.element('.ng-invalid[name=' + firstError + ']').focus();
                    //SweetAlert.swal("The form cannot be submitted because it contains validation errors!", "Errors are marked with a red, dashed border!", "error");

                    return;

                } else {
                    var lead = {};
                    var username = ($localStorage.currentUser) ? $localStorage.currentUser.username : "";
                    var sessionkey = ($localStorage.currentUser) ? $localStorage.currentUser.token : "";

                    lead = {
                        "Name": $scope.lead.Name,
                        "Email": $scope.lead.Email,
                        "Phone": $scope.lead.Phone,
                        "LeadsType": $scope.lead.LeadsType,
                        "Notes": $scope.lead.Notes,
                        "SessionKey": sessionkey
                    };

                    $scope.showSpinner = true;
                    // Load the data from the API
                    leadService.AddLeadsByAccount(lead, function (result) {
                        if (result.data && result.data.StatusCode == 17) {
                            membershipService.checkMemberAuthorization();
                        }

                        if (result.data && result.data.StatusCode == 0) {
                            notificationService.displaySuccess(result.data.StatusMsg);
                            $window.location.reload();
                        } else {
                            notificationService.displayError(result.data.StatusMsg);
                            $timeout(function () {
                                $scope.showSpinner = false;
                            }, 1000);
                        }
                        $uibModalInstance.dismiss('cancel');
                    });
                }
            }
        };

        $scope.cancel = function () {
            $uibModalInstance.dismiss('cancel');
        };

        function loadLeadsType() {
            $scope.items = ['Item 1', 'Item 2', 'Item 3'];
        }

        $scope.LeadsManager = {
            init: function () {
                loadLeadsType();
            }
        };

        $scope.LeadsManager.init();
    }]);