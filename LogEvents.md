## hotelbook-pro-connector

### HappyTravel.BaseConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 3011,
    "name": "BookingRequestStarted",
    "template": "Booking request started",
    "level": "Information"
  },
  {
    "id": 3012,
    "name": "BookingRequestCompleted",
    "template": "Booking request completed",
    "level": "Information"
  },
  {
    "id": 3013,
    "name": "BookingRequestFailed",
    "template": "Booking request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3014,
    "name": "CancelBookingRequestStarted",
    "template": "Cancel booking request started",
    "level": "Information"
  },
  {
    "id": 3015,
    "name": "CancelBookingRequestCompleted",
    "template": "Cancel booking request completed",
    "level": "Information"
  },
  {
    "id": 3016,
    "name": "CancelBookingRequestFailed",
    "template": "Cancel booking request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3017,
    "name": "BookingStatusRequestStarted",
    "template": "Booking status request started",
    "level": "Information"
  },
  {
    "id": 3018,
    "name": "BookingStatusRequestCompleted",
    "template": "Booking status request completed",
    "level": "Information"
  },
  {
    "id": 3019,
    "name": "BookingStatusRequestFailed",
    "template": "Booking status request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3020,
    "name": "SearchRequestStarted",
    "template": "Search request started",
    "level": "Information"
  },
  {
    "id": 3021,
    "name": "SearchRequestCompleted",
    "template": "Search request completed",
    "level": "Information"
  },
  {
    "id": 3022,
    "name": "SearchRequestFailed",
    "template": "Search request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3023,
    "name": "AccommodationRequestStarted",
    "template": "Accommodation request started",
    "level": "Information"
  },
  {
    "id": 3024,
    "name": "AccommodationRequestCompleted",
    "template": "Accommodation request completed",
    "level": "Information"
  },
  {
    "id": 3025,
    "name": "AccommodationRequestFailed",
    "template": "Accommodation request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3026,
    "name": "RoomRequestStarted",
    "template": "Room request started",
    "level": "Information"
  },
  {
    "id": 3027,
    "name": "RoomRequestCompleted",
    "template": "Room request completed",
    "level": "Information"
  },
  {
    "id": 3028,
    "name": "RoomRequestFailed",
    "template": "Room request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3032,
    "name": "DeadlineRequestStarted",
    "template": "Deadline request started",
    "level": "Information"
  },
  {
    "id": 3033,
    "name": "DeadlineRequestCompleted",
    "template": "Deadline request completed",
    "level": "Information"
  },
  {
    "id": 3034,
    "name": "DeadlineRequestFailed",
    "template": "Deadline request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  }
]
```

## nakijin

### HappyTravel.Nakijin.Core/Logging/LogEvents.json
```json
[
  {"id": 90000, "name": "MappingAccommodationsStart", "level": "Information", "template": "Started mapping of '{supplier}' accommodations", "argumentTypes": ["string"]}, 
  {"id": 90001, "name": "MappingAccommodationsOfSpecifiedCountryStart", "level": "Information", "template": "Started mapping of '{supplier}' accommodations of country with code '{countryCode}'", "argumentTypes": ["string", "string"]},
  {"id": 90002, "name": "MappingAccommodationsFinish", "level": "Information", "template": "Finished mapping of '{supplier}' accommodations", "argumentTypes": ["string"]},
  {"id": 90003, "name": "MappingAccommodationsOfSpecifiedCountryFinish", "level": "Information", "template": "Finished mapping of '{supplier}' accommodations of country with code '{countryCode}'", "argumentTypes": ["string", "string"]},
  {"id": 90004, "name": "MappingAccommodationsCancel", "level": "Information", "template": "Mapping accommodations of '{supplier}' was canceled by client request.", "argumentTypes": ["string"]},
  {"id": 90005, "name": "MappingAccommodationsError", "level": "Error", "template": "", "argumentTypes": []},
  
  {"id": 90100, "name": "MappingLocationsStart", "level": "Information", "template": "Started Mapping locations of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90101, "name": "MappingLocationsFinish", "level": "Information", "template": "Finished Mapping locations of '{supplier}'", "argumentTypes": ["string"]},
  {"id": 90102, "name": "MappingLocationsCancel", "level": "Information", "template": "Mapping locations of '{supplier}' was canceled by client request.", "argumentTypes": ["string"]},
  {"id": 90103, "name": "MappingLocationsError", "level": "Error", "template": ""},
  {"id": 90104, "name": "MappingCountriesStart", "level": "Information", "template": "Started Mapping countries of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90105, "name": "MappingCountriesFinish", "level": "Information", "template": "Finished Mapping countries of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90106, "name": "MappingLocalitiesStart", "level": "Information", "template": "Started Mapping localities of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90107, "name": "MappingLocalitiesFinish", "level": "Information", "template": "Finished Mapping localities of '{supplier}'", "argumentTypes": ["string"]},
  {"id": 90108, "name": "MappingLocalitiesOfSpecifiedCountryStart", "level": "Information", "template": "Started Mapping localities of '{supplier}' of country with code '{countryCode}'.", "argumentTypes": ["string", "string"]},
  {"id": 90109, "name": "MappingLocalitiesOfSpecifiedCountryFinish", "level": "Information", "template": "Finished Mapping localities of '{supplier}' of country {countryCode}", "argumentTypes": ["string", "string"]},
  {"id": 90110, "name": "MappingLocalityZonesStart", "level": "Information", "template": "Started Mapping locality zones of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90110, "name": "MappingLocalityZonesFinish", "level": "Information", "template": "Finished Mapping locality zones of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90111, "name": "MappingLocalityZonesOfSpecifiedCountryStart", "level": "Information", "template": "Started Mapping locality zones of '{supplier}' of country with code '{countryCode}'.", "argumentTypes": ["string", "string"]},
  {"id": 90112, "name": "MappingLocalityZonesOfSpecifiedCountryFinish", "level": "Information", "template": "Finished Mapping locality zones of '{supplier}' of country with code {countryCode}.", "argumentTypes": ["string", "string"]},
  {"id": 90113, "name": "MappingInvalidLocality", "level": "Warning", "template": "Locality '{defaultLocalityName}' of the country '{defaultCountryName}' is invalid and has been skipped. Supplier '{supplier}', Country '{serializedCountry}', Locality '{serializedLocality}'", "argumentTypes": ["string", "string", "string", "string", "string"]},

  {"id": 90200, "name": "MergingAccommodationsDataStart", "level": "Information", "template": "Started merging accommodations data"},
  {"id": 90201, "name": "MergingAccommodationsDataFinish", "level": "Information", "template": "Finished merging accommodations data"},
  {"id": 90202, "name": "MergingAccommodationsDataCancel", "level": "Information", "template": "Merging accommodations was canceled by client request."},
  {"id": 90203, "name": "MergingAccommodationsDataError", "template": "", "level": "Error"},
  {"id": 90204, "name": "CalculatingAccommodationsDataStart", "level": "Information", "template": "'Started calculation accommodations data of supplier '{supplier}'", "argumentTypes": ["string"]},
  {"id": 90205, "name": "CalculatingAccommodationsDataFinish", "level": "Information", "template": "Finished calculation of supplier '{supplier}' data.", "argumentTypes": ["string"]},
  {"id": 90206, "name": "CalculatingAccommodationsDataCancel", "level": "Information", "template": "Calculating data of supplier '{supplier}' was cancelled by client request", "argumentTypes": ["string"]},
  {"id": 90207, "name": "CalculatingAccommodationsDataError", "level": "Error", "template": "", "argumentTypes": []},
  {"id": 90208, "name": "CalculatingAccommodationsBatch", "level": "Information", "template": "{skip} {supplier} accommodations have been calculated", "argumentTypes": ["int", "string"]},
  
  {"id": 90250, "name": "InvalidContactInfo", "level": "Information", "template": "Accommodation with code '{accommodationCode}' has invalid contacts data", "argumentTypes": ["string"]},
  {"id": 90251, "name": "NumberOfAnalyzedInvalidAccommodations", "level": "Information", "template": "'{numberOfAccommodations}' accommodations have been analyzed", "argumentTypes": ["int"]},
  
  {"id": 90300, "name": "PreloadingAccommodationsStart", "level": "Information", "template": "Started Preloading accommodations of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90301, "name": "PreloadingAccommodationsFinish", "level": "Information", "template": "Finished Preloading accommodations of '{supplier}'.", "argumentTypes": ["string"]},
  {"id": 90302, "name": "PreloadingAccommodationsCancel", "level": "Information", "template": "Preloading accommodations of '{supplier}' was canceled by client request.", "argumentTypes": ["string"]},
  {"id": 90303, "name": "PreloadingAccommodationsError", "level": "Error", "template": ""},

  {"id": 90400, "name": "ConnectorClientError", "level": "Error", "template": "", "argumentTypes": []},
  
  {"id": 90500, "name": "SameAccommodationInOneSupplierError", "level": "Error", "template": "'{supplier}' have the same accommodations with codes '{firstAccommodationSupplierCode}' and '{secondAccommodationSupplierCode}'", "argumentTypes": ["string","string", "string"]},
  {"id": 90501, "name": "NotValidCoordinatesInAccommodation", "level": "Error", "template": "'{supplier}' have the accommodation with not valid coordinates, which code is '{accommodationSupplierCode}'", "argumentTypes": ["string", "string"]},
  {"id": 90502, "name": "NotValidDefaultNameOfAccommodation", "level": "Error", "template": "'{supplier}' have the accommodation with not valid default name, which code is '{accommodationSupplierCode}'", "argumentTypes": ["string", "string"]},
  
  {"id": 90600, "name": "SingleLocationPublished", "level": "Information", "template": "Location with htId '{htId}' has been published", "argumentTypes": ["string"]},
  {"id": 90601, "name": "LocationsPublished", "level": "Information", "template": "Locations with count '{count}' has been published", "argumentTypes": ["int"]},

  {"id": 90700, "name": "AccommodationsDuplicatesRemoveError", "level": "Error", "template": "Remove of accommodations duplicates failed."},

  {"id": 90800, "name": "WorkerStart", "level": "Information", "template": "Started '{workerName}'", "argumentTypes": ["string"]},
  {"id": 90801, "name": "WorkerFinish", "level": "Information", "template": "Finished '{workerName}'", "argumentTypes": ["string"]},
  {"id": 90802, "name": "UpdateCancel", "level": "Information", "template": "Updating data was canceled by client request.", "argumentTypes": []},
  {"id": 90803, "name": "UpdateError", "level": "Error", "template": ""},
  {"id": 90804, "name": "UpdateStart", "level": "Information", "template": "Updating data was started."},
  {"id": 90805, "name": "UpdateFinish", "level": "Information", "template": "Updating data was finished."}
]
```

## hotelbeds-connector

### HappyTravel.HotelbedsConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 30001,
    "name": "HotelbedsRequestResult",
    "level": "Debug",
    "template": "HotelbedsShoppingClient: {message}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30002,
    "name": "RoomSelectionNotFoundResponse",
    "level": "Warning",
    "template": "Could not find cached response for availability id {availabilityId}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30003,
    "name": "RoomSelectionNotFoundMapping",
    "level": "Warning",
    "template": "Could not find cached mapping for availability id {availabilityId}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30100,
    "name": "ApiBadRequest",
    "level": "Warning",
    "template": "HotelbedsShoppingClient: {message}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30102,
    "name": "ApiRateExceeded",
    "level": "Warning",
    "template": "HotelbedsShoppingClient: {message}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30103,
    "name": "ApiAuthorizationFailure",
    "level": "Critical",
    "template": "HotelbedsShoppingClient: {message}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30104,
    "name": "ApiUnknownError",
    "level": "Critical",
    "template": "HotelbedsShoppingClient: {message}",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 30105,
    "name": "ApiResponseDeserializationException",
    "level": "Critical",
    "template": "HotelbedsShoppingClient: ",
    "argumentTypes": []
  }
]
```

### HappyTravel.HotelbedsConnector.Updater/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 40001,
    "name": "StartedWorker",
    "level": "Information",
    "template": "Started worker '{workerName}'",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 40002,
    "name": "FinishedWorker",
    "level": "Information",
    "template": "Finished worker '{workerName}'",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 40003,
    "name": "CancellingOperation",
    "level": "Error",
    "template": "Cancelling operation '{operationName}'",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 40004,
    "name": "StaticDataUpdateHostedServiceException",
    "level": "Critical",
    "template": "Updater: ",
    "argumentTypes": []
  },
  {
    "id": 40005,
    "name": "StoppingOperation",
    "level": "Information",
    "template": "Stopping operation '{operationName}'",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 40006,
    "name": "StartingAccommodationUpdater",
    "level": "Information",
    "template": "Starting accommodation updater",
    "argumentTypes": []
  },
  {
    "id": 40007,
    "name": "AccommodationUpdaterException",
    "level": "Critical",
    "template": "Accommodation updater: ",
    "argumentTypes": []
  },
  {
    "id": 40008,
    "name": "AccommodationUpdaterGetHotels",
    "level": "Critical",
    "template": "Get hotels from DB. From {i} to {batchSizeInc}",
    "argumentTypes": [ "int", "int" ]
  },
  {
    "id": 40009,
    "name": "StartingCategoriesUpdate",
    "level": "Information",
    "template": "Starting raw data categories update",
    "argumentTypes": []
  },
  {
    "id": 40010,
    "name": "CategoryLoaderException",
    "level": "Critical",
    "template": "Category loader: ",
    "argumentTypes": []
  },
  {
    "id": 40011,
    "name": "StartingCountriesUpdate",
    "level": "Information",
    "template": "Starting raw data countries update",
    "argumentTypes": []
  },
  {
    "id": 40012,
    "name": "CountryLoaderException",
    "level": "Critical",
    "template": "Country loader: ",
    "argumentTypes": []
  },
  {
    "id": 40013,
    "name": "StartingFacilitiesUpdate",
    "level": "Information",
    "template": "Starting raw data facilities update",
    "argumentTypes": []
  },
  {
    "id": 40014,
    "name": "FacilityLoaderException",
    "level": "Critical",
    "template": "Facility loader: ",
    "argumentTypes": []
  },
  {
    "id": 40015,
    "name": "StartingHotelsUpdate",
    "level": "Information",
    "template": "Starting raw data hotels update with id '{updateId}'",
    "argumentTypes": [ "int" ]
  },
  {
    "id": 40016,
    "name": "DeactivateAllHotels",
    "level": "Information",
    "template": "Deactivate all hotels",
    "argumentTypes": []
  },
  {
    "id": 40017,
    "name": "HotelsLoaderException",
    "level": "Critical",
    "template": "Hotelts loader: ",
    "argumentTypes": []
  },
  {
    "id": 40018,
    "name": "FinishHotelsUpdate",
    "level": "Information",
    "template": "Finish raw data update with id '{updateId}'",
    "argumentTypes": [ "int" ]
  }
]
```

## edo

### Api/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 1001, "name": "GeoCoderException", "level": "Error", "template": "Getting google response exception"},
    {"id": 1006, "name": "InvitationCreated", "level": "Information", "template": "The invitation with type {InvitationType} created for the user '{Email}'", "argumentTypes": ["HappyTravel.Edo.Common.Enums.UserInvitationTypes", "string"]},
    {"id": 1007, "name": "AgentRegistrationFailed", "level": "Warning", "template": "Agent registration failed with error `{Error}`", "argumentTypes": ["string"]},
    {"id": 1008, "name": "AgentRegistrationSuccess", "level": "Information", "template": "Agent {Email} successfully registered", "argumentTypes": ["string"]},
    {"id": 1009, "name": "PayfortClientException", "level": "Critical", "template": "Payfort client exception"},
    {"id": 1010, "name": "AgencyAccountCreationSuccess", "level": "Information", "template": "Successfully created account for agency: '{AgencyId}', account id: {AccountId}", "argumentTypes": ["int", "int"]},
    {"id": 1011, "name": "AgencyAccountCreationFailed", "level": "Error", "template": "Failed to create account for agency {AgencyId}, error {Error}", "argumentTypes": ["int", "string"]},
    {"id": 1012, "name": "EntityLockFailed", "level": "Critical", "template": "Failed to lock entity {EntityType} with id: {EntityId}", "argumentTypes": ["string", "string"]},
    {"id": 1013, "name": "PayfortError", "level": "Error", "template": "Error deserializing payfort response: '{Content}'", "argumentTypes": ["string"]},
    {"id": 1014, "name": "ExternalPaymentLinkSendSuccess", "level": "Information", "template": "Successfully sent e-mail to {Email}", "argumentTypes": ["string"]},
    {"id": 1015, "name": "ExternalPaymentLinkSendFailed", "level": "Error", "template": "Error sending email to {Email}: {Error}", "argumentTypes": ["string", "string"]},
    {"id": 1017, "name": "UnableGetBookingDetailsFromNetstormingXml", "level": "Warning", "template": "Failed to get booking details from the Netstorming xml: {Xml}", "argumentTypes": ["string"]},
    {"id": 1018, "name": "UnableToAcceptNetstormingRequest", "level": "Warning", "template": "Unable to accept netstorming request"},
    {"id": 1020, "name": "BookingFinalizationFailure", "level": "Error", "template": "The booking finalization with the reference code: '{ReferenceCode}' has been failed with a message: {Message}", "argumentTypes": ["string", "string"]},
    {"id": 1021, "name": "BookingFinalizationPaymentFailure", "level": "Warning", "template": "The booking with reference code: '{ReferenceCode}' hasn't been paid", "argumentTypes": ["string"]},
    {"id": 1022, "name": "BookingFinalizationSuccess", "level": "Information", "template": "Successfully booked using account. Reference code: '{ReferenceCode}'", "argumentTypes": ["string"]},
    {"id": 1023, "name": "BookingFinalizationException", "level": "Critical", "template": "Booking finalization exception"},
    {"id": 1030, "name": "BookingResponseProcessFailure", "level": "Error", "template": "Booking response process failure. Error: {Error}", "argumentTypes": ["string"]},
    {"id": 1031, "name": "BookingResponseProcessSuccess", "level": "Information", "template": "The booking response with the reference code '{ReferenceCode} has been processed with message {Message}", "argumentTypes": ["string", "string"]},
    {"id": 1032, "name": "BookingResponseProcessStarted", "level": "Information", "template": "Start the booking response processing with the reference code '{ReferenceCode}'. Old status: {Status}", "argumentTypes": ["string", "HappyTravel.Edo.Common.Enums.BookingStatuses"]},
    {"id": 1040, "name": "BookingCancelFailure", "level": "Critical", "template": "Failed to cancel a booking with reference code: '{ReferenceCode}'. Error: {Error}", "argumentTypes": ["string", "string"]},
    {"id": 1041, "name": "BookingCancelSuccess", "level": "Information", "template": "Successfully cancelled a booking with reference code: '{ReferenceCode}'", "argumentTypes": ["string"]},
    {"id": 1042, "name": "BookingAlreadyCancelled", "level": "Information", "template": "Skipping cancellation for a booking with reference code: '{ReferenceCode}'. Already cancelled.", "argumentTypes": ["string"]},
    {"id": 1050, "name": "BookingRegistrationSuccess", "level": "Information", "template": "Successfully registered a booking with reference code: '{ReferenceCode}", "argumentTypes": ["string"]},
    {"id": 1051, "name": "BookingRegistrationFailure", "level": "Error", "template": "Failed to register a booking. AvailabilityId: '{AvailabilityId}'. Itinerary number: {ItineraryNumber}. Passenger name: {MainPassengerName}. Error: {Error}", "argumentTypes": ["System.Guid", "string", "string", "string"]},
    {"id": 1060, "name": "BookingByAccountSuccess", "level": "Information", "template": "Booking by account success"},
    {"id": 1061, "name": "BookingByAccountFailure", "level": "Error", "template": "Failed to book using account. Reference code: '{ReferenceCode}'. Error: {Error}", "argumentTypes": ["string", "string"]},
    {"id": 1070, "name": "BookingRefreshStatusSuccess", "level": "Information", "template": "Successfully refreshed status for a booking with reference code: '{ReferenceCode}'. Old status: {OldStatus}. New status: {Status}", "argumentTypes": ["string", "HappyTravel.Edo.Common.Enums.BookingStatuses", "HappyTravel.EdoContracts.Accommodations.Enums.BookingStatusCodes"]},
    {"id": 1071, "name": "BookingRefreshStatusFailure", "level": "Error", "template": "Failed to refresh status for a booking with reference code: '{ReferenceCode}' while getting info from a supplier. Error: {Error}", "argumentTypes": ["string", "string"]},
    {"id": 1072, "name": "BookingConfirmationFailure", "level": "Critical", "template": "Booking '{ReferenceCode} confirmation failed: '{Error}", "argumentTypes": ["string", "string"]},
    {"id": 1073, "name": "BookingEvaluationFailure", "level": "Warning", "template": "EvaluateOnConnector returned status code: {Status}, error: {Error}", "argumentTypes": ["System.Nullable<int>", "string"]},
    {"id": 1074, "name": "BookingEvaluationCancellationPoliciesFailure", "level": "Error", "template": "EvaluateOnConnector returned cancellation policies with 0 penalty"},
    {"id": 1100, "name": "ExternalAdministratorAuthorizationSuccess", "level": "Debug", "template": "Successfully authorized external administrator"},
    {"id": 1101, "name": "AdministratorAuthorizationFailure", "level": "Warning", "template": "Administrator authorization failed"},
    {"id": 1103, "name": "InternalAdministratorAuthorizationSuccess", "level": "Debug", "template": "Successfully authorized administrator '{Email}'", "argumentTypes": ["string"]},
    {"id": 1110, "name": "AgentAuthorizationSuccess", "level": "Debug", "template": "Successfully authorized agent '{Email}' for '{Permissions}'", "argumentTypes": ["string", "string"]},
    {"id": 1111, "name": "AgentAuthorizationFailure", "level": "Warning", "template": "Agent authorization failure: '{Error}'", "argumentTypes": ["string"]},
    {"id": 1120, "name": "CounterpartyAccountCreationFailure", "level": "Error", "template": "Failed to create account for counterparty {Id}, error {Error}", "argumentTypes": ["int", "string"]},
    {"id": 1121, "name": "CounterpartyAccountCreationSuccess", "level": "Information", "template": "Successfully created account for counterparty: '{CounterpartyId}', account id: {AccountId}", "argumentTypes": ["int", "int"]},
    {"id": 1125, "name": "ServiceAccountAuthorizationSuccess", "level": "Debug", "template": "Service account '{ClientId}' authorized successfully", "argumentTypes": ["string"]},
    {"id": 1126, "name": "ServiceAccountAuthorizationFailure", "level": "Warning", "template": "Service account authorization failed. Error: {Error}", "argumentTypes": ["string"]},
    {"id": 1130, "name": "LocationNormalized", "level": "Information", "template": "Location normalized"},
    {"id": 1140, "name": "MultiSupplierAvailabilitySearchStarted", "level": "Information", "template": "Starting availability search for {CheckInDate} - {CheckOutDate}. Locations: '{LocationHtIds}', nationality: '{Nationality}', rooms: {RoomCount}", "argumentTypes": ["string", "string", "string[]", "string", "int"]},
    {"id": 1141, "name": "SupplierAvailabilitySearchStarted", "level": "Information", "template": "Availability search with id '{SearchId}' on supplier '{Supplier}' started", "argumentTypes": ["System.Guid", "HappyTravel.SuppliersCatalog.Suppliers"]},
    {"id": 1142, "name": "SupplierAvailabilitySearchSuccess", "level": "Information", "template": "Availability search with id '{SearchId}' on supplier '{Supplier}' finished successfully with '{ResultCount}' results", "argumentTypes": ["System.Guid", "HappyTravel.SuppliersCatalog.Suppliers", "int"]},
    {"id": 1143, "name": "SupplierAvailabilitySearchFailure", "level": "Warning", "template": "Availability search with id '{SearchId}' on supplier '{Supplier}' finished with state '{TaskState}', error '{Error}'", "argumentTypes": ["System.Guid", "HappyTravel.SuppliersCatalog.Suppliers", "HappyTravel.Edo.Api.Models.Availabilities.AvailabilitySearchTaskState", "string"]},
    {"id": 1145, "name": "SupplierAvailabilitySearchException", "level": "Error", "template": "Supplier availability search exception on supplier '{Supplier}'", "argumentTypes": ["HappyTravel.SuppliersCatalog.Suppliers"]},
    {"id": 1150, "name": "CounterpartyStateAuthorizationSuccess", "level": "Debug", "template": "Successfully checked counterparty state for agent {Email}", "argumentTypes": ["string"]},
    {"id": 1151, "name": "CounterpartyStateAuthorizationFailure", "level": "Warning", "template": "Counterparty of agent '{Email}' has wrong state {State}", "argumentTypes": ["string", "HappyTravel.Edo.Common.Enums.CounterpartyStates"]},
    {"id": 1200, "name": "DefaultLanguageKeyIsMissingInFieldOfLocationsTable", "level": "Warning", "template": "Default language key is missing in field of locations table"},
    {"id": 1300, "name": "ConnectorClientException", "level": "Error", "template": "Connector client exception, url {RequestUrl}, response: {Response}", "argumentTypes": ["string", "string"]},
    {"id": 1301, "name": "SupplierConnectorRequestError", "level": "Error", "template": "Error executing connector request to {Url}: '{Error}', status code: '{Status}'", "argumentTypes": ["string", "string", "System.Nullable<int>"]},
    {"id": 1302, "name": "SupplierConnectorRequestDuration", "level": "Information", "template": "Request to {Url} finished at {ElapsedMilliseconds} ms.", "argumentTypes": ["string", "long"]},
    {"id": 1310, "name": "GetTokenForConnectorError", "level": "Error", "template": "Something went wrong while requesting the access token. Error: {Error}. Using existing token: '{Token}' with expiry date '{ExpiryDate}'", "argumentTypes": ["string", "string", "System.DateTime"]},
    {"id": 1311, "name": "UnauthorizedConnectorResponse", "level": "Debug", "template": "Unauthorized response was returned from '{RequestUri}'. Refreshing token...", "argumentTypes": ["string"]},
    {"id": 1400, "name": "CaptureMoneyForBookingSuccess", "level": "Information", "template": "Successfully captured money for a booking with reference code: '{ReferenceCode}'", "argumentTypes": ["string"]},
    {"id": 1401, "name": "CaptureMoneyForBookingFailure", "level": "Error", "template": "Failed to capture money for a booking with reference code: '{ReferenceCode}'. Error: Invalid payment method: {PaymentType}", "argumentTypes": ["string", "HappyTravel.Edo.Common.Enums.PaymentTypes"]},
    {"id": 1402, "name": "ChargeMoneyForBookingSuccess", "level": "Information", "template": "Successfully charged money for a booking with reference code: '{ReferenceCode}'", "argumentTypes": ["string"]},
    {"id": 1403, "name": "ChargeMoneyForBookingFailure", "level": "Error", "template": "Failed to charge money for a booking with reference code: '{ReferenceCode} with error {Error}", "argumentTypes": ["string", "string"]},
    {"id": 1410, "name": "ProcessPaymentChangesForBookingSuccess", "level": "Information", "template": "Successfully processes payment changes. Old payment status: {OldPaymentStatus}. New payment status: {PaymentStatus}. Payment: '{PaymentReferenceCode}'. Booking reference code: '{BookingReferenceCode}'", "argumentTypes": ["HappyTravel.Edo.Common.Enums.BookingPaymentStatuses", "HappyTravel.Edo.Common.Enums.PaymentStatuses", "string", "string"]},
    {"id": 1411, "name": "ProcessPaymentChangesForBookingSkip", "level": "Warning", "template": "Skipped booking status update while processing payment changes. Payment status: {PaymentStatus}. Payment: '{PaymentReferenceCode}'. Booking reference code: '{BookingReferenceCode}'", "argumentTypes": ["HappyTravel.Edo.Common.Enums.PaymentStatuses", "string", "string"]},
    {"id": 1412, "name": "ProcessPaymentChangesForBookingFailure", "level": "Error", "template": "Failed to process payment changes, could not find the corresponding booking. Payment status: {Status}. Payment: '{ReferenceCode}'", "argumentTypes": ["HappyTravel.Edo.Common.Enums.PaymentStatuses", "string"]},
    {"id": 1501, "name": "ElasticAnalyticsEventSendError", "level": "Error", "template": "Sending event to elasticsearch failed"},
    {"id": 1601, "name": "MapperClientException", "level": "Error", "template": "Mapper client exception"},
    {"id": 1602, "name": "MapperClientErrorResponse", "level": "Error", "template": "Request to mapper failed: {Message}:{StatusCode}. Requested HtIds {HtIds}", "argumentTypes": ["string","int", "string[]"]},
    {"id": 1701, "name": "CounterpartyAccountAddedNotificationFailure", "level": "Error", "template": "Counterparty {CounterpartyId} account added notification failed with error {Error}", "argumentTypes": ["int","string"]},
    {"id": 1702, "name": "AgentRegistrationNotificationFailure", "level": "Error", "template": "Agent registration notification failure with error {Error}", "argumentTypes": ["string"]},
    {"id": 1703, "name": "ChildAgencyRegistrationNotificationFailure", "level": "Error", "template": "Child agency registration notification failed"},
    {"id": 1704, "name": "CounterpartyAccountSubtractedNotificationFailure", "level": "Error", "template": "Counterparty {CounterpartyId} account subtracted notification failed with error {Error}", "argumentTypes": ["int","string"]},
    {"id": 1705, "name": "CounterpartyAccountIncreasedManuallyNotificationFailure", "level": "Error", "template": "Counterparty {CounterpartyId} account increasedManually notification failed with error {Error}", "argumentTypes": ["int","string"]},
    {"id": 1706, "name": "CounterpartyAccountDecreasedManuallyNotificationFailure", "level": "Error", "template": "Counterparty {CounterpartyId} account decreasedManually notification failed with error {Error}", "argumentTypes": ["int","string"]},
    {"id": 1707, "name": "ExternalPaymentLinkGenerationSuccess", "level": "Information", "template": "Successfully generated payment link for {Email}", "argumentTypes": ["string"]},
    {"id": 1708, "name": "ExternalPaymentLinkGenerationFailed", "level": "Error", "template": "Error generating payment link for {Email}: {Error}", "argumentTypes": ["string", "string"]},
    {"id": 1709, "name": "GetAccommodationByHtIdFailed", "level": "Error", "template": "Error getting accommodation for HtId '{HtId}': error: {Error}", "argumentTypes": [ "string", "string" ]},
    {"id": 1800, "name": "SendConfirmationEmailFailure", "level": "Error", "template": "Error sending booking confirmation email to property owner. Received empty list of email addresses from mapper. Reference code {ReferenceCode}", "argumentTypes": [ "string" ]},
    {"id": 1801, "name": "ConnectorClientUnexpectedResponse", "level": "Error", "template":  "Unexpected response received from connector. StatusCode: `{StatusCode}`, request uri: `{Uri}`, response: {Response}", "argumentTypes": [ "System.Net.HttpStatusCode", "System.Uri", "string" ]},
    {"id": 1802, "name": "MapperClientUnexpectedResponse", "level": "Error", "template":  "Unexpected response received from mapper. StatusCode: `{StatusCode}`, request uri: `{Uri}`, response: {Response}", "argumentTypes": [ "System.Net.HttpStatusCode", "System.Uri", "string" ]},
    {"id": 1803, "name": "MapperClientRequestTimeout", "level": "Warning", "template":  "Request to mapper failed with timeout"}
]
```

## iwtx-connector

### HappyTravel.IwtxConnector.Common/Extensions/LogEvents.json
```json
[
  {"id": 20001, "name": "FillingDataException", "level": "Error", "template": "Fill data exception"},
  {"id": 20010, "name": "AvailabilitySearchError", "level": "Warning", "template": "{error}", "argumentTypes": ["string"]},
  {"id": 20011, "name": "BookingError", "level": "Error", "template": "{error}", "argumentTypes": ["string"]},
  {"id": 20012, "name": "RemarksError", "level": "Error", "template": "{error}", "argumentTypes": ["string"]},
  {"id": 20020, "name": "StaticDataUpdateException", "level": "Error", "template": "Static data update exception"},
  {"id": 20030, "name": "DataReadError", "level": "Error", "template": "{Error}", "argumentTypes": ["string"]},
  {"id": 20030, "name": "DataWriteError", "level": "Error", "template": "{Error}", "argumentTypes": ["string"]},
  {"id": 20050, "name": "StaticDataUpdateStart", "level": "Information", "template": "Starting static data update"},
  {"id": 20051, "name": "StaticDataUpdateEnd", "level": "Information", "template":  "Total hotels fetched: {fetchedHotelCount}", "argumentTypes": ["string"]},
  {"id": 20061, "name": "StaticDataUpdateCityProcessStart", "level": "Information", "template":  "Started processing city '{cityName}[{cityCode}]' from '{cityCountryName}[{cityCountryCode}]'. Hotels available: {hotelsCount})", "argumentTypes": ["string", "string", "string", "string", "int"]},
  {"id": 20062, "name": "StaticDataUpdateCityProcessEnd", "level": "Information", "template":  "Finished processing city '{cityName}[{cityCode}]'from '{cityCountryName}[{cityCountryCode}]'", "argumentTypes": ["string", "string", "string", "string"]},
  {"id": 20070, "name": "SupplierInternalServerError", "level": "Error", "template": "Illusions server error: {error}", "argumentTypes": ["string"] },
  {"id": 20071, "name": "SupplierUnsuccessResponse", "level": "Warning", "template": "Illusions unsuccess response: {error}", "argumentTypes": ["string"]},
  {"id": 20072, "name": "SupplierResponseWithErrorMessage", "level": "Warning", "template": "Illusions returned an error: {error}", "argumentTypes": ["string"]},
  {"id": 20073, "name": "SupplierRequestException", "level": "Warning", "template":  "HttpRequest exception"},
  {"id": 20074, "name": "SupplierRequestTimeout", "level": "Warning", "template":  "HttpRequest timeout: {error}", "argumentTypes": ["string"]},
  {"id": 20080, "name": "SupplierResponseDeserializationError", "level": "Warning", "template": "Failed to deserialize Illusions response: {deserializationError}, response content: {responseContent}", "argumentTypes": ["string", "string"] },
  {"id": 20090, "name": "GetHotelDetailsError", "level": "Error", "template": "Error while fetching hotel details for city '{cityCode}': {hotelDetailsError}","argumentTypes": ["string", "string"] },
  {"id": 20091, "name": "GetHotelDetailsCodesMismatch", "level": "Error", "template": "Error while fetching hotel details for city '{cityCode}'. Could not get requested hotel codes: {notFetchedHotelCodes}", "argumentTypes": ["string", "string[]"] },
  {"id": 20092, "name": "GetEmptyCityCodeError", "level": "Error", "template": "Empty city code for city {cityName} in country {countryName}", "argumentTypes": ["string", "string"] },
  {"id": 20100, "name": "SupplierDataProcessingError", "level": "Warning", "template": "Data processing errors: {errors}", "argumentTypes": ["string[]"] }
]
```

## gifu

### HappyTravel.Gifu.Api/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 81000, "name": "ClientIdRetrievalFailure", "level": "Warning", "template": "Could not get client id for authenticated user"},
    {"id": 81010, "name": "VccIssueRequestStarted", "level": "Information", "template": "Processing VCC issue request for '{ReferenceCode}'. Amount: {Amount} {Currency},", "argumentTypes": ["string", "decimal", "string"]},
    {"id": 81015, "name": "VccIssueRequestFailure", "level": "Error", "template": "Processing VCC issue request for '{ReferenceCode}' failed: '{Error}'", "argumentTypes": ["string", "string"]},
    {"id": 81016, "name": "VccIssueRequestSuccess", "level": "Information", "template": "Processing VCC issue request for '{ReferenceCode}' completed successfully. UniqueId: '{UniqueId}'", "argumentTypes": ["string", "string"]}
]
```

## jumeirah-connector

### HappyTravel.JumeirahConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {"id": 90000, "name": "WideAvailabilitySearchStarted", "template":"Started wide availability search for hotels: '{HotelCodes}' check in '{CheckIn}' check out '{CheckOut}', room count: {RoomCount}", "level": "Information", "argumentTypes": ["System.Collections.Generic.List<string>", "DateTime", "DateTime", "int"]},
  {"id": 90001, "name": "WideAvailabilitySearchFinished", "template":"Finished wide availability search with availability id {AvailabilityId}. Availabilities found in {HotelCount} hotels", "level": "Information", "argumentTypes": ["string", "int"]},
  {"id": 90010, "name": "HotelAvailabilitySearchStarted", "template":"Started hotel availability search for '{HotelCode}' check in '{CheckIn}' check out '{CheckOut}', room count: {RoomCount}", "level": "Information", "argumentTypes": ["string", "DateTime", "DateTime", "int"]},
  {"id": 90015, "name": "HotelRoomAvailabilityError", "template":"Hotel room availability for room index {RoomIndex} hotel '{HotelCode}' check in '{CheckIn}' check out '{CheckOut}' failed with '{Error}' [{StatusCode}]", "level": "Warning", "argumentTypes": ["int","string", "DateTime", "DateTime", "string", "int?"]},
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

## rakuten-connector

### HappyTravel.RakutenConnector.Updater/Infrastructure/Logging/LogEvents.json
```json
[
    {"id": 30201, "name": "UpdatingRawPropertyCodes", "level": "Information", "template": "Updating property codes: {PropertyCodes}", "argumentTypes": ["string[]"]},
    {"id": 30210, "name": "RawDataUpdateStarted", "level": "Information", "template": "Starting raw data update with id: {Id}", "argumentTypes": ["int"]},
    {"id": 30211, "name": "RawDataUpdateFinished", "level": "Information", "template": "Raw data update with id: {Id} finished successfully", "argumentTypes": ["int"]}
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

## columbus-connector

### HappyTravel.ColumbusConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {
    "id": 3011,
    "name": "BookingRequestStarted",
    "template": "Booking request started",
    "level": "Information"
  },
  {
    "id": 3012,
    "name": "BookingRequestCompleted",
    "template": "Booking request completed",
    "level": "Information"
  },
  {
    "id": 3013,
    "name": "BookingRequestFailed",
    "template": "Booking request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3014,
    "name": "CancelBookingRequestStarted",
    "template": "Cancel booking request started",
    "level": "Information"
  },
  {
    "id": 3015,
    "name": "CancelBookingRequestCompleted",
    "template": "Cancel booking request completed",
    "level": "Information"
  },
  {
    "id": 3016,
    "name": "CancelBookingRequestFailed",
    "template": "Cancel booking request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3017,
    "name": "BookingStatusRequestStarted",
    "template": "Booking status request started",
    "level": "Information"
  },
  {
    "id": 3018,
    "name": "BookingStatusRequestCompleted",
    "template": "Booking status request completed",
    "level": "Information"
  },
  {
    "id": 3019,
    "name": "BookingStatusRequestFailed",
    "template": "Booking status request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3020,
    "name": "SearchRequestStarted",
    "template": "Search request started",
    "level": "Information"
  },
  {
    "id": 3021,
    "name": "SearchRequestCompleted",
    "template": "Search request completed",
    "level": "Information"
  },
  {
    "id": 3022,
    "name": "SearchRequestFailed",
    "template": "Search request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3023,
    "name": "AccommodationRequestStarted",
    "template": "Accommodation request started",
    "level": "Information"
  },
  {
    "id": 3024,
    "name": "AccommodationRequestCompleted",
    "template": "Accommodation request completed",
    "level": "Information"
  },
  {
    "id": 3025,
    "name": "AccommodationRequestFailed",
    "template": "Accommodation request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3026,
    "name": "RoomRequestStarted",
    "template": "Room request started",
    "level": "Information"
  },
  {
    "id": 3027,
    "name": "RoomRequestCompleted",
    "template": "Room request completed",
    "level": "Information"
  },
  {
    "id": 3028,
    "name": "RoomRequestFailed",
    "template": "Room request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 3032,
    "name": "DeadlineRequestStarted",
    "template": "Deadline request started",
    "level": "Information"
  },
  {
    "id": 3033,
    "name": "DeadlineRequestCompleted",
    "template": "Deadline request completed",
    "level": "Information"
  },
  {
    "id": 3034,
    "name": "DeadlineRequestFailed",
    "template": "Deadline request failed with error `{Error}`",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80001,
    "name": "SupplierSearchRequestFailed",
    "template": "Search request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80002,
    "name": "SupplierBookingInitRequestFailed",
    "template": "Booking init request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80003,
    "name": "SupplierBookingCommitRequestFailed",
    "template": "Booking commit request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80004,
    "name": "SupplierBookingCancelRequestFailed",
    "template": "Booking cancellation request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80005,
    "name": "SupplierBookingStatusRequestFailed",
    "template": "Get booking status request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80006,
    "name": "SupplierDeadlineRequestFailed",
    "template": "Get deadline request failed with error `{Error}`",
    "level": "Error",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80007,
    "name": "SupplierSearchCompletedWithErrors",
    "template": "Search completed with errors `{Errors}`",
    "level": "Warning",
    "argumentTypes": [ "string[]" ]
  },
  {
    "id": 80008,
    "name": "GetAvailabilityFromStorageFailed",
    "template": "Get availability by id `{AvailabilityId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string" ]
  },
  {
    "id": 80009,
    "name": "GetRoomContractSetFromStorageFailed",
    "template": "Get room contract set by availabilityId `{AvailabilityId}` and room contract set id `{RoomContractSetId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string", "System.Guid" ]
  },
  {
    "id": 80010,
    "name": "GetAccommodationAvailabilityFromStorageFailed",
    "template": "Get accommodation by availabilityId `{AvailabilityId}` and room contract set id `{RoomContractSetId}` from storage failed",
    "level": "Warning",
    "argumentTypes": [ "string", "System.Guid" ]
  }
]
```

## travelgatex-connector

### HappyTravel.TravelgateXConnector.Api/Infrastructure/Logging/LogEvents.json
```json
[
  {"id": 3001, "name": "SupplierQuoteRequestFailed", "template":"Quote request failed", "level": "Error"},
  {"id": 3002, "name": "SupplierSearchRequestFailed", "template":"Search request failed", "level": "Error"},
  {"id": 3003, "name": "SupplierBookRequestFailed", "template":"Booking request failed", "level": "Error"},
  {"id": 3004, "name": "SupplierCancelRequestFailed", "template":"Cancellation request failed", "level": "Error"},
  {"id": 3005, "name": "SupplierStatusRequestFailed", "template":"Get status request failed", "level": "Error"},
  {"id": 3006, "name": "SupplierSearchCompletedWithErrors", "template":"Search completed with errors `{Errors}` and warnings `{Warnings}`", "level": "Warning", "argumentTypes": ["string[]", "string[]"]},
  {"id": 3007, "name": "GetSupplierFailed", "template": "Cannot get supplier info with code {Code}", "level": "Error", "argumentTypes": ["string"]},
  {"id": 3011, "name": "BookingRequestStarted", "template": "Booking request started", "level": "Information"},
  {"id": 3012, "name": "BookingRequestCompleted", "template": "Booking request completed", "level": "Information"},
  {"id": 3013, "name": "BookingRequestFailed", "template": "Booking request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3014, "name": "CancelBookingRequestStarted", "template": "Cancel booking request started", "level": "Information"},
  {"id": 3015, "name": "CancelBookingRequestCompleted", "template": "Cancel booking request completed", "level": "Information"},
  {"id": 3016, "name": "CancelBookingRequestFailed", "template": "Cancel booking request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3017, "name": "BookingStatusRequestStarted", "template": "Booking status request started", "level": "Information"},
  {"id": 3018, "name": "BookingStatusRequestCompleted", "template": "Booking status request completed", "level": "Information"},
  {"id": 3019, "name": "BookingStatusRequestFailed", "template": "Booking status request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3020, "name": "SearchRequestStarted", "template": "Search request started", "level": "Information"},
  {"id": 3021, "name": "SearchRequestCompleted", "template": "Search request completed", "level": "Information"},
  {"id": 3022, "name": "SearchRequestFailed", "template": "Search request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3023, "name": "AccommodationRequestStarted", "template": "Accommodation request started", "level": "Information"},
  {"id": 3024, "name": "AccommodationRequestCompleted", "template": "Accommodation request completed", "level": "Information"},
  {"id": 3025, "name": "AccommodationRequestFailed", "template": "Accommodation request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3026, "name": "RoomRequestStarted", "template": "Room request started", "level": "Information"},
  {"id": 3027, "name": "RoomRequestCompleted", "template": "Room request completed", "level": "Information"},
  {"id": 3028, "name": "RoomRequestFailed", "template": "Room request failed with error `{Error}`", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3029, "name": "GetAvailabilityRequestFromStorageFailed", "template":"Get availability request by id `{AvailabilityId}` from storage failed", "level": "Warning", "argumentTypes": ["string"]},
  {"id": 3030, "name": "GetQuoteOptionIdFromStorageFailed", "template":"Get quoteOptionId by availabilityId `{AvailabilityId}` and room contract set id `{RoomContractSetId}` from storage failed", "level": "Warning", "argumentTypes": ["string", "System.Guid"]},
  {"id": 3031, "name": "GetAccommodationFromStorageFailed", "template":"Get accommodation by availabilityId `{AvailabilityId}` from storage failed", "level": "Warning", "argumentTypes": ["string"]}
]
```

### HappyTravel.TravelgateXConnector.Updater/Infrastructure/Logging/LogEvents.json
```json
﻿[
  {"id": 3101, "name": "StartingUpdater", "template":"Updater {UpdaterName} started", "level": "Information", "argumentTypes": ["string"]},
  {"id": 3101, "name": "UpdatingComplete", "template":"Updater {UpdaterName} completed", "level": "Information", "argumentTypes": ["string"]},
  {"id": 3102, "name": "UpdatingFailed", "template":"Updater {UpdaterName} failed", "level": "Error", "argumentTypes": ["string"]},
  {"id": 3103, "name": "SupplierHotelsFetchingStarted", "template":"Started fetching hotels from supplier `{SupplierCode}`", "level": "Information", "argumentTypes": ["string"]},
  {"id": 3104, "name": "SupplierHotelsFetchingFailed", "template":"Fetching hotels from supplier `{SupplierCode}` failed", "level": "Error", "argumentTypes": ["string"]},
  {"id": 3105, "name": "SupplierHotelsFetchingCompleted", "template":"Fetching hotels from supplier `{SupplierCode}` completed. Fetched {Count} hotels", "level": "Information", "argumentTypes": ["string", "int"]},
  {"id": 3106, "name": "UpdatingHotelsCompleted", "template":"Hotels updated `{Updated}`, new hotels added `{Added}`, hotels deactivated `{Deactivated}`", "level": "Information", "argumentTypes": ["int", "int", "int"]},
  {"id": 3107, "name": "AccommodationDuplicatesFound", "template": "Founded {Count} accommodation duplicates", "level": "Warning", "argumentTypes": ["int"]}
]
```

## travelgatex-channel

### HappyTravel.TravelgateXChannel.Api/Infrastructure/Logging/LogEvents.json
```json
﻿[
  {"id": 20001, "name": "ModelBindingFailure", "level": "Error", "template": "Failed to bind model to '{Type}'", "argumentTypes": ["string"]},
  {"id": 20002, "name": "ErrorResponseReceived", "level": "Warning", "template": "API request to {Url} failed with {StatusCode}. Request '{Request}', response {Response}.", "argumentTypes": ["string","System.Net.HttpStatusCode?","string", "string"]},
  {"id": 20101, "name": "GetClientCredentialsFailure", "level": "Warning", "template": "Failed to get client credentials from the request model"},
  {"id": 20102, "name": "AvailTimeoutReached", "level": "Warning", "template": "Availability search request timeout reached {TimeoutSeconds} sec", "argumentTypes": ["int"]},
  {"id": 20103, "name": "ParseOptionsFailure", "level": "Warning", "template": "Could not parse option parameters from {Parameters}", "argumentTypes": ["System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>"]}, 
  {"id": 20201, "name": "ApiRequest", "level": "Debug", "template": "API request to {Url} completed with {StatusCode}. RequestBody: `{RequestBody}`, response body: `{ResponseBody}`", "argumentTypes": ["string", "System.Net.HttpStatusCode?", "string", "string"]},
  {"id": 20202, "name": "AvailabilityResultReturned", "level": "Information", "template": "Returned {ResultCount} availability results after {AttemptCount} attempts", "argumentTypes": ["int", "int"]},
  {"id": 20202, "name": "ValuationResultReturned", "level": "Information", "template": "Valuation result returned successfully after {AttemptCount} attempts.", "argumentTypes": ["int"]},
  {"id": 20221, "name": "ClientCheckFailure", "level": "Warning", "template": "Failed validate client credentials for {ClientName}", "argumentTypes": ["string"]},
  {"id": 20222, "name": "EvaluationResult", "level": "Information", "template": "Evaluation returned `{Result}`", "argumentTypes": ["string"]},
  {"id": 20223, "name": "EvaluationFailed", "level": "Error", "template": "Evaluation failed with error `{Error}`", "argumentTypes": ["string"]},
  {"id": 20224, "name": "UnhandledException", "level": "Error", "template": "Unhandled exception"}
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

**Updated on: 9/2/2021 10:33:28 PM**
