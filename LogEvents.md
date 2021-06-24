## nakijin

### HappyTravel.Nakijin.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {"id": 90000, "name": "MappingAccommodationsStart", "level": "Information", "source": "AccommodationMapper", "isException": false}, 
  {"id": 90001, "name": "MappingAccommodationsOfSpecifiedCountryStart", "level": "Information", "source": "AccommodationMapper", "isException": false},
  {"id": 90002, "name": "MappingAccommodationsFinish", "level": "Information", "source": "AccommodationMapper", "isException": false},
  {"id": 90003, "name": "MappingAccommodationsOfSpecifiedCountryFinish", "level": "Information", "source": "AccommodationMapper", "isException": false},
  {"id": 90004, "name": "MappingAccommodationsCancel", "level": "Information", "source": "AccommodationMapper", "isException": false},
  {"id": 90005, "name": "MappingAccommodationsError", "level": "Error", "source": "AccommodationMapper", "isException": true},

  {"id": 90100, "name": "MappingLocationsStart", "level": "Information", "source": "LocationMapper", "isException": false},
  {"id": 90101, "name": "MappingLocationsFinish", "level": "Information", "source": "LocationMapper", "isException": false},
  {"id": 90102, "name": "MappingLocationsCancel", "level": "Information", "source": "LocationMapper", "isException": false},
  {"id": 90103, "name": "MappingLocationsError", "level": "Error", "source": "LocationMapper", "isException": true},
  {"id": 90104, "name": "MappingCountriesStart", "level": "Information", "source": "CountryMapper", "isException": false},
  {"id": 90105, "name": "MappingCountriesFinish", "level": "Information", "source": "CountryMapper", "isException": false},
  {"id": 90106, "name": "MappingLocalitiesStart", "level": "Information", "source": "LocalityMapper", "isException": false},
  {"id": 90107, "name": "MappingLocalitiesFinish", "level": "Information", "source": "LocalityMapper", "isException": false},
  {"id": 90108, "name": "MappingLocalitiesOfSpecifiedCountryStart", "level": "Information", "source": "LocalityMapper", "isException": false},
  {"id": 90109, "name": "MappingLocalitiesOfSpecifiedCountryFinish", "level": "Information", "source": "LocalityMapper", "isException": false},
  {"id": 90110, "name": "MappingLocalityZonesStart", "level": "Information", "source": "LocalityZoneMapper", "isException": false},
  {"id": 90110, "name": "MappingLocalityZonesFinish", "level": "Information", "source": "LocalityZoneMapper", "isException": false},
  {"id": 90111, "name": "MappingLocalityZonesOfSpecifiedCountryStart", "level": "Information", "source": "LocalityZoneMapper", "isException": false},
  {"id": 90112, "name": "MappingLocalityZonesOfSpecifiedCountryFinish", "level": "Information", "source": "LocalityZoneMapper", "isException": false},
  {"id": 90113, "name": "MappingInvalidLocality", "level": "Warning", "source": "LocalityMapper", "isException": false},

  {"id": 90200, "name": "MergingAccommodationsDataStart", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  {"id": 90201, "name": "MergingAccommodationsDataFinish", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  {"id": 90202, "name": "MergingAccommodationsDataCancel", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  {"id": 90203, "name": "MergingAccommodationsDataError", "level": "Error", "source": "AccommodationDataMerger", "isException": true},
  {"id": 90204, "name": "CalculatingAccommodationsDataStart", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  {"id": 90205, "name": "CalculatingAccommodationsDataFinish", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  {"id": 90206, "name": "CalculatingAccommodationsDataCancel", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  {"id": 90207, "name": "CalculatingAccommodationsDataError", "level": "Error", "source": "AccommodationDataMerger", "isException": true},
  {"id": 90208, "name": "CalculatingAccommodationsBatch", "level": "Information", "source": "AccommodationDataMerger", "isException": false},
  
  {"id": 90300, "name": "PreloadingAccommodationsStart", "level": "Information", "source": "AccommodationPreloader", "isException": false},
  {"id": 90301, "name": "PreloadingAccommodationsFinish", "level": "Information", "source": "AccommodationPreloader", "isException": false},
  {"id": 90302, "name": "PreloadingAccommodationsCancel", "level": "Information", "source": "AccommodationPreloader", "isException": false},
  {"id": 90303, "name": "PreloadingAccommodationsError", "level": "Error", "source": "AccommodationPreloader", "isException": true},

  {"id": 90400, "name": "ConnectorClientError", "level": "Error", "source": "ConnectorClient", "isException": true},
  
  {"id": 90500, "name": "SameAccommodationInOneSupplierError", "level": "Error", "source": "AccommodationMapper", "isException": false},
  {"id": 90501, "name": "NotValidCoordinatesInAccommodation", "level": "Error", "source": "AccommodationMapper", "isException": false},
  {"id": 90502, "name": "NotValidDefaultNameOfAccommodation", "level": "Error", "source": "AccommodationMapper", "isException": false},
  
  {"id": 90502, "name": "LocationsPublished", "level": "Information", "source": "StaticDataPublicationService", "isException": false}
]
```

## travelgatex-channel

### HappyTravel.TravelgateXChannel.Api/Infrastructure/Logging/LogEvents.json
```json
﻿[
  {"id": 20001, "name": "ModelBindingFailure", "level": "Error", "template": "Failed to bind model to '{Type}'", "argumentTypes": ["string"]},
  {"id": 20002, "name": "ErrorResponseReceived", "level": "Warning", "template": "API request to {Url} failed with {StatusCode}: '{Error}'.", "argumentTypes": ["string","System.Net.HttpStatusCode?","string"]},
  {"id": 20101, "name": "GetClientCredentialsFailure", "level": "Warning", "template": "Failed to get client credentials from the request model"},
  {"id": 20102, "name": "AvailTimeoutReached", "level": "Warning", "template": "Availability search request timeout reached {TimeoutSeconds} sec", "argumentTypes": ["int"]},
  {"id": 20103, "name": "ParseOptionsFailure", "level": "Warning", "template": "Could not parse option parameters from {Parameters}", "argumentTypes": ["System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>"]}, 
  {"id": 20201, "name": "ApiRequestSent", "level": "Debug", "template": "API request to {Url} executed successfully.", "argumentTypes": ["string"]},
  {"id": 20202, "name": "AvailabilityResultReturned", "level": "Information", "template": "Returned {ResultCount} availability results after {AttemptCount} attempts", "argumentTypes": ["int", "int"]},
  {"id": 20202, "name": "ValuationResultReturned", "level": "Information", "template": "Valuation result returned successfully after {AttemptCount} attempts.", "argumentTypes": ["int"]},
  {"id": 20221, "name": "ClientCheckFailure", "level": "Warning", "template": "Failed validate client credentials for {ClientName}", "argumentTypes": ["string"]}
]
```

## edo

### Api/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 1001, "name": "GeoCoderException", "level": "Error", "source": "GoogleGeoCoder", "isException": true},
    {"id": 1006, "name": "InvitationCreated", "level": "Information", "source": "AgentInvitationService", "isException": false},
    {"id": 1007, "name": "AgentRegistrationFailed", "level": "Warning", "source": "AgentRegistrationService", "isException": false},
    {"id": 1008, "name": "AgentRegistrationSuccess", "level": "Information", "source": "AgentRegistrationService", "isException": false}, 
    {"id": 1009, "name": "PayfortClientException", "level": "Critical", "source": "PayfortService", "isException": true},
    {"id": 1010, "name": "AgencyAccountCreationSuccess", "level": "Information", "source": "AccountManagementService", "isException": false},
    {"id": 1011, "name": "AgencyAccountCreationFailed", "level": "Error", "source": "AccountManagementService", "isException": false},
    {"id": 1012, "name": "EntityLockFailed", "level": "Critical", "source": "EntityLocker", "isException": false},
    {"id": 1013, "name": "PayfortError", "level": "Error", "source": "PayfortService", "isException": false},
    {"id": 1014, "name": "ExternalPaymentLinkSendSuccess", "level": "Information", "source": "PaymentLinkService", "isException": false},
    {"id": 1015, "name": "ExternalPaymentLinkSendFailed", "level": "Error", "source": "PaymentLinkService", "isException": false},
    {"id": 1017, "name": "UnableGetBookingDetailsFromNetstormingXml", "level": "Warning", "source": "Test", "isException": false}, 
    {"id": 1018, "name": "UnableToAcceptNetstormingRequest", "level": "Warning", "source": "Test", "isException": false},
    {"id": 1020, "name": "BookingFinalizationFailure", "level": "Error", "source": "BookingRequestExecutor", "isException": false},
    {"id": 1021, "name": "BookingFinalizationPaymentFailure", "level": "Warning", "source": "BookingRequestExecutor", "isException": false}, 
    {"id": 1022, "name": "BookingFinalizationSuccess", "level": "Information", "source": "BookingRequestExecutor", "isException": false},
    {"id": 1023, "name": "BookingFinalizationException", "level": "Critical", "source": "BookingRequestExecutor", "isException": true},
    {"id": 1030, "name": "BookingResponseProcessFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1031, "name": "BookingResponseProcessSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1032, "name": "BookingResponseProcessStarted", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1040, "name": "BookingCancelFailure", "level": "Critical", "source": "BookingService", "isException": false},
    {"id": 1041, "name": "BookingCancelSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1042, "name": "BookingAlreadyCancelled", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1050, "name": "BookingRegistrationSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1051, "name": "BookingRegistrationFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1060, "name": "BookingByAccountSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1061, "name": "BookingByAccountFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1070, "name": "BookingRefreshStatusSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1071, "name": "BookingRefreshStatusFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1072, "name": "BookingConfirmationFailure", "level": "Critical", "source": "BookingChangesProcessor", "isException": false},
    {"id": 1073, "name": "BookingEvaluationFailure", "level": "Critical", "source": "BookingEvaluationService", "isException": false},
    {"id": 1100, "name": "AdministratorAuthorizationSuccess", "level": "Debug", "source": "AdministratorPermissionsAuthorizationHandler", "isException": false}, 
    {"id": 1101, "name": "AdministratorAuthorizationFailure", "level": "Warning", "source": "AdministratorPermissionsAuthorizationHandler", "isException": false},
    {"id": 1110, "name": "AgentAuthorizationSuccess", "level": "Debug", "source": "InAgencyPermissionAuthorizationHandler", "isException": false}, 
    {"id": 1111, "name": "AgentAuthorizationFailure", "level": "Warning", "source": "InAgencyPermissionAuthorizationHandler", "isException": false},
    {"id": 1120, "name": "CounterpartyAccountCreationFailure", "level": "Error", "source": "AccountManagementService", "isException": false},
    {"id": 1121, "name": "CounterpartyAccountCreationSuccess", "level": "Information", "source": "AccountManagementService", "isException": false},
    {"id": 1125, "name": "ServiceAccountAuthorizationSuccess", "level": "Debug", "source": "InAgencyPermissionAuthorizationHandler", "isException": false},
    {"id": 1126, "name": "ServiceAccountAuthorizationFailure", "level": "Warning", "source": "InAgencyPermissionAuthorizationHandler", "isException": false},
    {"id": 1130, "name": "LocationNormalized", "level": "Information", "source": "LocationNormalizer", "isException": false},
    {"id": 1140, "name": "MultiProviderAvailabilitySearchStarted", "level": "Debug", "source": "AvailabilitySearchScheduler", "isException": false},
    {"id": 1141, "name": "ProviderAvailabilitySearchStarted", "level": "Debug", "source": "AvailabilitySearchScheduler", "isException": false},
    {"id": 1142, "name": "ProviderAvailabilitySearchSuccess", "level": "Debug", "source": "AvailabilitySearchScheduler", "isException": false},
    {"id": 1143, "name": "ProviderAvailabilitySearchFailure", "level": "Error", "source": "AvailabilitySearchScheduler", "isException": false},
    {"id": 1145, "name": "ProviderAvailabilitySearchException", "level": "Critical", "source": "AvailabilitySearchScheduler", "isException": true},
    {"id": 1150, "name": "CounterpartyStateAuthorizationSuccess", "level": "Debug", "source": "MinCounterpartyStateAuthorizationHandler", "isException": false},
    {"id": 1151, "name": "CounterpartyStateAuthorizationFailure", "level": "Warning", "source": "MinCounterpartyStateAuthorizationHandler", "isException": false},
    {"id": 1200, "name": "DefaultLanguageKeyIsMissingInFieldOfLocationsTable", "level": "Warning", "source": "LocationNormalizer", "isException": false},
    {"id": 1300, "name": "ConnectorClientException", "level": "Critical", "source": "ConnectorClient", "isException": true},
    {"id": 1301, "name": "SupplierConnectorRequestError", "level": "Error", "source": "SupplierConnector", "isException": false},
    {"id": 1302, "name": "SupplierConnectorRequestDuration", "level": "Information", "source": "SupplierConnector", "isException": false},
    {"id": 1310, "name": "GetTokenForConnectorError", "level": "Error", "source": "ConnectorClient", "isException": false},
    {"id": 1311, "name": "UnauthorizedConnectorResponse", "level": "Debug", "source": "ConnectorClient", "isException": false},
    {"id": 1400, "name": "CaptureMoneyForBookingSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1401, "name": "CaptureMoneyForBookingFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1402, "name": "ChargeMoneyForBookingSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1403, "name": "ChargeMoneyForBookingFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1410, "name": "ProcessPaymentChangesForBookingSuccess", "level": "Information", "source": "BookingService", "isException": false},
    {"id": 1411, "name": "ProcessPaymentChangesForBookingSkip", "level": "Warning", "source": "BookingService", "isException": false},
    {"id": 1412, "name": "ProcessPaymentChangesForBookingFailure", "level": "Error", "source": "BookingService", "isException": false},
    {"id": 1501, "name": "ElasticAnalyticsEventSendError", "level": "Error", "source": "AnalyticsService", "isException": false},
    {"id": 1601, "name": "MapperClientException", "level": "Error", "source": "AccommodationMapperClient", "isException": true},
    {"id": 1701, "name": "CounterpartyAccountAddedNotificationFailure", "level": "Error", "source": "CounterpartyBillingNotificationService", "isException": false},
    {"id": 1702, "name": "AgentRegistrationNotificationFailure", "level": "Error", "source": "InvitationService", "isException": false},
    {"id": 1703, "name": "ChildAgencyRegistrationNotificationFailure", "level": "Error", "source": "InvitationService", "isException": false},
    {"id": 1704, "name": "CounterpartyAccountSubtractedNotificationFailure", "level": "Error", "source": "CounterpartyBillingNotificationService", "isException": false},
    {"id": 1705, "name": "CounterpartyAccountIncreasedManuallyNotificationFailure", "level": "Error", "source": "CounterpartyBillingNotificationService", "isException": false},
    {"id": 1706, "name": "CounterpartyAccountDecreasedManuallyNotificationFailure", "level": "Error", "source": "CounterpartyBillingNotificationService", "isException": false}
]
```

## jumeirah-connector

### HappyTravel.JumeirahConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {"id": 90000, "name": "WideAvailabilitySearchStarted", "template":"Started wide availability search for hotels: '{HotelCodes}' check in '{CheckIn}' check out '{CheckOut}', room count: {RoomCount}", "level": "Information", "argumentTypes": ["System.Collections.Generic.List<string>", "DateTime", "DateTime", "int"]},
  {"id": 90001, "name": "WideAvailabilitySearchFinished", "template":"Finished wide availability search with availability id {AvailabilityId}. Availabilities found in {HotelCount} hotels", "level": "Information", "argumentTypes": ["string", "int"]},
  {"id": 90010, "name": "HotelAvailabilitySearchStarted", "template":"Started hotel availability search for '{HotelCode}' check in '{CheckIn}' check out '{CheckOut}', room count: {RoomCount}", "level": "Information", "argumentTypes": ["string", "DateTime", "DateTime", "int"]},
  {"id": 90015, "name": "HotelRoomAvailabilityError", "template":"Hotel room availability for room index {RoomIndex} hotel '{HotelCode}' check in '{CheckIn}' check out '{CheckOut}' failed with '{Error}' [{StatusCode}]", "level": "Error", "argumentTypes": ["int","string", "DateTime", "DateTime", "string", "int?"]},
  {"id": 90020, "name": "WideAvailabilityCachedResultNotFound", "template":"Could not get cached availability for availability id '{AvailabilityId}'", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 90021, "name": "WideAvailabilityCachedAccommodationResultNotFound", "template":"Could not find cached availability for id '{AvailabilityId}' and hotel code '{HotelCode}'", "level": "Warning", "argumentTypes": ["string", "string"]},
  {"id": 90030, "name": "RoomSelectionAvailabilityStarted", "template":"Started getting room availability for availability '{AvailabilityId}' and hotel code '{HotelCode}'", "level": "Information", "argumentTypes": ["string", "string"]},
  {"id": 90031, "name": "RoomSelectionAvailabilityFinished", "template":"Finished getting room availability for availability '{AvailabilityId}' and hotel code '{HotelCode}', sets count {RoomContractSetCount}", "level": "Information", "argumentTypes": ["string", "string", "int"]},
  {"id": 90035, "name": "RoomSelectionCachedResultNotFount", "template":"Could not get cached room contract set for availability id '{AvailabilityId} and room contract set id {RoomContractSetId}'", "level": "Warning", "argumentTypes": ["string", "Guid"]},
  {"id": 90036, "name": "RoomSelectionCachedResultMappingNotFount", "template":"Could not id mapping for cached availability id '{AvailabilityId} and room contract set id {RoomContractSetId}'", "level": "Warning", "argumentTypes": ["string", "Guid"]},
  {"id": 90040, "name": "BookingEvaluationStarted", "template":"Started booking evaluation for availability '{AvailabilityId}' and room contract set '{RoomContractSetId}'", "level": "Information", "argumentTypes": ["string", "Guid"]},
  {"id": 90041, "name": "BookingEvaluationFinished", "template":"Finished booking evaluation for availability '{AvailabilityId}' and room contract set '{RoomContractSetId}'. Is available: '{IsAvailable}'", "level": "Information", "argumentTypes": ["string", "Guid", "bool"]},
  {"id": 90046, "name": "BookingEvaluationMappingFoundNoRoom", "template":"Could not map to booking evaluation. Could not find a room to match requested room type/rate type code '{RoomTypeCode}/{RatePlanCode}'", "level": "Information", "argumentTypes": ["string", "string"]},
  {"id": 90050, "name": "BookingEvaluationStorageResultNotFound", "template":"Could not evaluation result for availability '{AvailabilityId}' and room contract set id '{RoomContractSetId}'", "level": "Warning", "argumentTypes": ["string", "Guid"]},
  {"id": 90060, "name": "BookingProcessStarted", "template":"Started booking availability id '{AvailabilityId}' room contract set id '{RoomContractSetId}'. Room count: {RoomCount} reference code {ReferenceCode}", "level": "Information", "argumentTypes": ["string", "Guid", "int", "string"]},
  {"id": 90063, "name": "BookingProcessRequestGenerationStarted", "template":"Creating booking request for hotel {HotelCode} and rooms '{Rooms}'", "level": "Information", "argumentTypes": ["string", "string[]"]},
  {"id": 90064, "name": "BookingProcessRequestGenerationCreditCard", "template":"Requesting a credit card for rooms '{Rooms}'", "level": "Information", "argumentTypes": ["string[]"]},
  {"id": 90068, "name": "BookingProcessReservationRequestFailed", "template":"Failed to make reservation: '{Error}':{Code}", "level": "Warning", "argumentTypes": ["string", "int?"]},
  {"id": 90069, "name": "BookingProcessReservationSuccess", "template":"Reservation completed successfully with confirmation codes: '{ConfirmationCodes}'", "level": "Information", "argumentTypes": ["string[]"]},
  {"id": 90080, "name": "BookingCancellationStarted", "template":"Started cancelling a booking with reference code {ReferenceCode}", "level": "Information", "argumentTypes": ["string"]},
  {"id": 90082, "name": "BookingRoomCancellationStarted", "template":"Cancelling a reservation with confirmation code {ConfirmationCode}", "level": "Information", "argumentTypes": ["string"]},
  {"id": 90083, "name": "BookingRoomCancellationSuccess", "template":"Successfully cancelled a reservation with code {ConfirmationCode}", "level": "Information", "argumentTypes": ["string"]},
  {"id": 90084, "name": "BookingRoomCancellationFailure", "template":"Failed to cancel a reservation with code {ConfirmationCode}, error: '{Error}':{StatusCode}", "level": "Warning", "argumentTypes": ["string", "string", "int?"]},
  {"id": 90085, "name": "BookingCancellationFailure", "template":"Failed to cancel a booking with errors: {Errors}", "level": "Warning", "argumentTypes": ["string[]"]},
  {"id": 90086, "name": "BookingPartiallyCancellationFailure", "template":"Booking with reference code {ReferenceCode} cancelled partially. Need administrator assistance", "level": "Error", "argumentTypes": ["string"]},
  {"id": 90090, "name": "BookingGetStatusStarted", "template":"Getting booking with reference code {ReferenceCode}", "level": "Information", "argumentTypes": ["string"]},
  {"id": 90091, "name": "BookingGetRoomReservationStatusStarted", "template":"Getting reservation status for confirmation number {ConfirmationNumber}", "level": "Information", "argumentTypes": ["string"]},
  {"id": 90092, "name": "BookingGetRoomReservationStatusFailure", "template":"Failed to get status for confirmation number {ConfirmationNumber}: '{Error}': {StatusCode}", "level": "Warning", "argumentTypes": ["string", "string", "int?"]},
  {"id": 90092, "name": "BookingGetRoomReservationStatusSuccess", "template":"Successfully fetched booking status for confirmation number {ConfirmationNumber}: '{Status}'", "level": "Information", "argumentTypes": ["string", "string"]},
  {"id": 90100, "name": "CreditCardServiceCardRequested", "template":"Requested a credit card to {DueDate} for reference code '{ReferenceCode}'. Amount: {Amount} {Currency}", "level": "Information", "argumentTypes": ["DateTime","string", "decimal", "string"]},
  {"id": 90101, "name": "CreditCardServiceCardFailure", "template":"Failed to get credit card for reference code '{ReferenceCode}'. Error: {Error}", "level": "Warning", "argumentTypes": ["string", "string"]},
  {"id": 90102, "name": "CreditCardServiceCardSuccess", "template":"Successfully got credit card for reference code '{ReferenceCode}'", "level": "Information", "argumentTypes": ["string"]}
]
```

## travelgatex-connector

### HappyTravel.TravelgateXConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {"id": 3001, "name": "QuoteRequestFailed", "template":"Quote request failed", "level": "Error"},
  {"id": 3002, "name": "SearchRequestFailed", "template":"Search request failed", "level": "Error"},
  {"id": 3003, "name": "BookRequestFailed", "template":"Booking request failed", "level": "Error"},
  {"id": 3004, "name": "CancelRequestFailed", "template":"Cancellation request failed", "level": "Error"},
  {"id": 3005, "name": "StatusRequestFailed", "template":"Get status request failed", "level": "Error"}
]
```

## iwtx-connector

### HappyTravel.IwtxConnector.Common/Extensions/LogEvents.json
```json
[
  {"id": 20001, "name": "FillingDataException", "level": "Critical", "source": "", "isException": true},
  {"id": 20010, "name": "ClientRequestError", "level": "Error", "source": "", "isException": false},
  {"id": 20020, "name": "StaticDataUpdateException", "level": "Critical", "source": "UpdaterService", "isException": true},
  {"id": 20030, "name": "DataReadError", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 20031, "name": "DataWriteError", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 20041, "name": "IllusionsRequest", "level": "Debug", "source": "IllusionsClient", "isException": false},
  {"id": 20042, "name": "IllusionsResponse", "level": "Debug", "source": "IllusionsClient", "isException": false},
  {"id": 20050, "name": "StaticDataUpdateStart", "level": "Information", "source": "DataUpdaterService", "isException": false},
  {"id": 20051, "name": "StaticDataUpdateEnd", "level": "Information", "source": "DataUpdaterService", "isException": false},
  {"id": 20061, "name": "StaticDataUpdateCityProcessStart", "level": "Information", "source": "DataUpdaterService", "isException": false},
  {"id": 20062, "name": "StaticDataUpdateCityProcessEnd", "level": "Information", "source": "DataUpdaterService", "isException": false},
  {"id": 20070, "name": "SupplierInternalServerError", "level": "Critical", "source": "IllusionsClient", "isException": false },
  {"id": 20071, "name": "SupplierUnsuccessResponse", "level": "Information", "source": "IllusionsClient", "isException": false },
  {"id": 20072, "name": "SupplierResponseWithErrorMessage", "level": "Information", "source": "IllusionsClient", "isException": false },
  {"id": 20073, "name": "SupplierRequestException", "level": "Error", "source": "IllusionsClient", "isException": true },
  {"id": 20080, "name": "SupplierResponseDeserializationError", "level": "Error", "source": "IllusionsClient", "isException": false },
  {"id": 20090, "name": "GetHotelDetailsError", "level": "Error", "source": "HotelManager", "isException": false },
  {"id": 20091, "name": "GetHotelDetailsCodesMismatch", "level": "Error", "source": "HotelManager", "isException": false },
  {"id": 20092, "name": "GetEmptyCityCodeError", "level": "Error", "source": "HotelManager", "isException": false },
  {"id": 20100, "name": "SupplierDataProcessingError", "level": "Error", "source": "HotelManager", "isException": false }
]
```

## osaka

### HappyTravel.Osaka.Api/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 2001, "name": "StartUploadingLocations", "level": "Information", "source": "LocationsManagementService", "isException": false},
    {"id": 2002, "name": "RemoveLocationsFromIndex", "level": "Information", "source": "LocationsManagementService", "isException": false},
    {"id": 2003, "name": "GetLocationsFromMapper", "level": "Information", "source": "LocationsManagementService", "isException": false},
    {"id": 2004, "name": "CompleteUploadingLocations", "level": "Information", "source": "LocationsManagementService", "isException": false},
    {"id": 2005, "name": "UploadingError", "level": "Critical", "source": "LocationsManagementService", "isException": false},
    {"id": 2006, "name": "PredictionsQuery", "level": "Information", "source": "LocationsService", "isException": false},
    {"id": 2007, "name": "AddLocations", "level": "Information", "source": "LocationsManagementService", "isException": false},
    {"id": 2008, "name": "UpdateLocations", "level": "Information", "source": "LocationsManagementService", "isException": false},
    {"id": 2009, "name": "RemoveLocations", "level": "Information", "source": "LocationsManagementService", "isException": false}
]
```

## columbus-connector

### HappyTravel.ColumbusConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 80001, "name": "WideAvailabilitySearchError", "level": "Warning", "source": "WideAvailabilitySearchService", "isException": false}
]
```

## rakuten-connector

### HappyTravel.RakutenConnector.Updater/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 30201, "name": "UpdatingRawPropertyCodes", "level": "Information", "source": "AccommodationUpdater", "isException": false}
]
```

### HappyTravel.RakutenConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 30001, "name": "RakutenRequestResult", "level": "Debug", "source": "RakutenShoppingClient", "isException": false},
    {"id": 30100, "name": "ApiBadRequest", "level": "Warning", "source": "RakutenShoppingClient", "isException": false},
    {"id": 30102, "name": "ApiRateExceeded", "level": "Warning", "source": "RakutenShoppingClient", "isException": false},
    {"id": 30103, "name": "ApiAuthorizationFailure", "level": "Critical", "source": "RakutenShoppingClient", "isException": false},
    {"id": 30104, "name": "ApiUnknownError", "level": "Critical", "source": "RakutenShoppingClient", "isException": false},
    {"id": 30105, "name": "ApiResponseDeserializationException", "level": "Critical", "source": "RakutenShoppingClient", "isException": true}
]
```

## etg-connector

### HappyTravel.EtgConnector.Common/Infrastructure/Logging/LogEvents.json
```json
﻿[
  {"id": 5003, "name": "EtgWebhook", "level": "Information", "source": "BookingWebhookResponseService", "isException": false},
  {"id": 5020, "name": "BookingNotFoundInAudit", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5021, "name": "BookingNotFoundInCache", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5022, "name": "BookingNotFoundInOrderResponse", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5023, "name": "RoomContractSetNotFound", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5024, "name": "AccommodationDataNotFoundInCache", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5025, "name": "BookingReservationFailure", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5026, "name": "BookingFinalizationRequestFailure", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5027, "name": "BookingFinalizationFailure", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5028, "name": "BookingCancellationFailure", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5029, "name": "BookingOrderResponseFailure", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5030, "name": "IncorrectBookingOrderReceived", "level": "Error", "source": "BookingService", "isException": false},
  {"id": 5031, "name": "BookingOrderExists", "level": "Error", "source": "BookingService", "isException": false}
 ]
```

## hiroshima

### HappyTravel.Hiroshima.DirectManager/Infrastructure/Logging/LogEvents.json
```json
﻿[
  {
    "id": 7001,
    "name": "BookingWebhookClientException",
    "level": "Error",
    "source": "BookingWebhookClient",
    "isException": true
  },
  {
    "id": 7002,
    "name": "InvitationCreated",
    "level": "Information",
    "source": "ManagerInvitationService",
    "isException": false
  },
  {
    "id": 7003,
    "name": "ManagerRegistrationFailed",
    "level": "Warning",
    "source": "ManagerRegistrationService",
    "isException": false
  },
  {
    "id": 7004,
    "name": "ManagerRegistrationSuccess",
    "level": "Information",
    "source": "ManagerRegistrationService",
    "isException": false
  }
]
```

**Updated on: 6/24/2021 10:46:41 PM**
