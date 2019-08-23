using System;

namespace MySql.Data.MySqlClient
{
	public enum MySqlErrorCode
	{
		None,
		HashCheck = 1000,
		ISAMCheck,
		No,
		Yes,
		CannotCreateFile,
		CannotCreateTable,
		CannotCreateDatabase,
		DatabaseCreateExists,
		DatabaseDropExists,
		DatabaseDropDelete,
		DatabaseDropRemoveDir,
		CannotDeleteFile,
		CannotFindSystemRecord,
		CannotGetStatus,
		CannotGetWorkingDirectory,
		CannotLock,
		CannotOpenFile,
		FileNotFound,
		CannotReadDirectory,
		CannotSetWorkingDirectory,
		CheckRead,
		DiskFull,
		DuplicateKey,
		ErrorOnClose,
		ErrorOnRead,
		ErrorOnRename,
		ErrorOnWrite,
		FileUsed,
		FileSortAborted,
		FormNotFound,
		GetErrorNumber,
		IllegalHA,
		KeyNotFound,
		NotFormFile,
		NotKeyFile,
		OldKeyFile,
		OpenAsReadOnly,
		OutOfMemory,
		OutOfSortMemory,
		UnexepectedEOF,
		ConnectionCountError,
		OutOfResources,
		UnableToConnectToHost,
		HandshakeError,
		DatabaseAccessDenied,
		AccessDenied,
		NoDatabaseSelected,
		UnknownCommand,
		ColumnCannotBeNull,
		UnknownDatabase,
		TableExists,
		BadTable,
		NonUnique,
		ServerShutdown,
		BadFieldError,
		WrongFieldWithGroup,
		WrongGroupField,
		WrongSumSelected,
		WrongValueCount,
		TooLongIdentifier,
		DuplicateFieldName,
		DuplicateKeyName,
		DuplicateKeyEntry,
		WrongFieldSpecifier,
		ParseError,
		EmptyQuery,
		NonUniqueTable,
		InvalidDefault,
		MultiplePrimaryKey,
		TooManyKeys,
		TooManyKeysParts,
		TooLongKey,
		KeyColumnDoesNotExist,
		BlobUsedAsKey,
		TooBigFieldLength,
		WrongAutoKey,
		Ready,
		NormalShutdown,
		GotSignal,
		ShutdownComplete,
		ForcingClose,
		IPSocketError,
		NoSuchIndex,
		WrongFieldTerminators,
		BlobsAndNoTerminated,
		TextFileNotReadable,
		FileExists,
		LoadInfo,
		AlterInfo,
		WrongSubKey,
		CannotRemoveAllFields,
		CannotDropFieldOrKey,
		InsertInfo,
		UpdateTableUsed,
		NoSuchThread,
		KillDenied,
		NoTablesUsed,
		TooBigSet,
		NoUniqueLogFile,
		TableNotLockedForWrite,
		TableNotLocked,
		BlobCannotHaveDefault,
		WrongDatabaseName,
		WrongTableName,
		TooBigSelect,
		UnknownError,
		UnknownProcedure,
		WrongParameterCountToProcedure,
		WrongParametersToProcedure,
		UnknownTable,
		FieldSpecifiedTwice,
		InvalidGroupFunctionUse,
		UnsupportedExtenstion,
		TableMustHaveColumns,
		RecordFileFull,
		UnknownCharacterSet,
		TooManyTables,
		TooManyFields,
		TooBigRowSize,
		StackOverrun,
		WrongOuterJoin,
		NullColumnInIndex,
		CannotFindUDF,
		CannotInitializeUDF,
		UDFNoPaths,
		UDFExists,
		CannotOpenLibrary,
		CannotFindDLEntry,
		FunctionNotDefined,
		HostIsBlocked,
		HostNotPrivileged,
		AnonymousUser,
		PasswordNotAllowed,
		PasswordNoMatch,
		UpdateInfo,
		CannotCreateThread,
		WrongValueCountOnRow,
		CannotReopenTable,
		InvalidUseOfNull,
		RegExpError,
		MixOfGroupFunctionAndFields,
		NonExistingGrant,
		TableAccessDenied,
		ColumnAccessDenied,
		IllegalGrantForTable,
		GrantWrongHostOrUser,
		NoSuchTable,
		NonExistingTableGrant,
		NotAllowedCommand,
		SyntaxError,
		DelayedCannotChangeLock,
		TooManyDelayedThreads,
		AbortingConnection,
		PacketTooLarge,
		NetReadErrorFromPipe,
		NetFCntlError,
		NetPacketsOutOfOrder,
		NetUncompressError,
		NetReadError,
		NetReadInterrupted,
		NetErrorOnWrite,
		NetWriteInterrupted,
		TooLongString,
		TableCannotHandleBlob,
		TableCannotHandleAutoIncrement,
		DelayedInsertTableLocked,
		WrongColumnName,
		WrongKeyColumn,
		WrongMergeTable,
		DuplicateUnique,
		BlobKeyWithoutLength,
		PrimaryCannotHaveNull,
		TooManyRows,
		RequiresPrimaryKey,
		NoRAIDCompiled,
		UpdateWithoutKeysInSafeMode,
		KeyDoesNotExist,
		CheckNoSuchTable,
		CheckNotImplemented,
		CannotDoThisDuringATransaction,
		ErrorDuringCommit,
		ErrorDuringRollback,
		ErrorDuringFlushLogs,
		ErrorDuringCheckpoint,
		NewAbortingConnection,
		DumpNotImplemented,
		FlushMasterBinLogClosed,
		IndexRebuild,
		MasterError,
		MasterNetRead,
		MasterNetWrite,
		FullTextMatchingKeyNotFound,
		LockOrActiveTransaction,
		UnknownSystemVariable,
		CrashedOnUsage,
		CrashedOnRepair,
		WarningNotCompleteRollback,
		TransactionCacheFull,
		SlaveMustStop,
		SlaveNotRunning,
		BadSlave,
		MasterInfo,
		SlaveThread,
		TooManyUserConnections,
		SetConstantsOnly,
		LockWaitTimeout,
		LockTableFull,
		ReadOnlyTransaction,
		DropDatabaseWithReadLock,
		CreateDatabaseWithReadLock,
		WrongArguments,
		NoPermissionToCreateUser,
		UnionTablesInDifferentDirectory,
		LockDeadlock,
		TableCannotHandleFullText,
		CannotAddForeignConstraint,
		NoReferencedRow,
		RowIsReferenced,
		ConnectToMaster,
		QueryOnMaster,
		ErrorWhenExecutingCommand,
		WrongUsage,
		WrongNumberOfColumnsInSelect,
		CannotUpdateWithReadLock,
		MixingNotAllowed,
		DuplicateArgument,
		UserLimitReached,
		SpecifiedAccessDeniedError,
		LocalVariableError,
		GlobalVariableError,
		NotDefaultError,
		WrongValueForVariable,
		WrongTypeForVariable,
		VariableCannotBeRead,
		CannotUseOptionHere,
		NotSupportedYet,
		MasterFatalErrorReadingBinLog,
		SlaveIgnoredTable,
		IncorrectGlobalLocalVariable,
		WrongForeignKeyDefinition,
		KeyReferenceDoesNotMatchTableReference,
		OpearnColumnsError,
		SubQueryNoOneRow,
		UnknownStatementHandler,
		CorruptHelpDatabase,
		CyclicReference,
		AutoConvert,
		IllegalReference,
		DerivedMustHaveAlias,
		SelectReduced,
		TableNameNotAllowedHere,
		NotSupportedAuthMode,
		SpatialCannotHaveNull,
		CollationCharsetMismatch,
		SlaveWasRunning,
		SlaveWasNotRunning,
		TooBigForUncompress,
		ZipLibMemoryError,
		ZipLibBufferError,
		ZipLibDataError,
		CutValueGroupConcat,
		WarningTooFewRecords,
		WarningTooManyRecords,
		WarningNullToNotNull,
		WarningDataOutOfRange,
		WaningDataTruncated,
		WaningUsingOtherHandler,
		CannotAggregateTwoCollations,
		DropUserError,
		RevokeGrantsError,
		CannotAggregateThreeCollations,
		CannotAggregateNCollations,
		VariableIsNotStructure,
		UnknownCollation,
		SlaveIgnoreSSLParameters,
		ServerIsInSecureAuthMode,
		WaningFieldResolved,
		BadSlaveUntilCondition,
		MissingSkipSlave,
		ErrorUntilConditionIgnored,
		WrongNameForIndex,
		WrongNameForCatalog,
		WarningQueryCacheResize,
		BadFullTextColumn,
		UnknownKeyCache,
		WarningHostnameWillNotWork,
		UnknownStorageEngine,
		WaningDeprecatedSyntax,
		NonUpdateableTable,
		FeatureDisabled,
		OptionPreventsStatement,
		DuplicatedValueInType,
		TruncatedWrongValue,
		TooMuchAutoTimestampColumns,
		InvalidOnUpdate,
		UnsupportedPreparedStatement,
		GetErroMessage,
		GetTemporaryErrorMessage,
		UnknownTimeZone,
		WarningInvalidTimestamp,
		InvalidCharacterString,
		WarningAllowedPacketOverflowed,
		ConflictingDeclarations,
		StoredProcedureNoRecursiveCreate,
		StoredProcedureAlreadyExists,
		StoredProcedureDoesNotExist,
		StoredProcedureDropFailed,
		StoredProcedureStoreFailed,
		StoredProcedureLiLabelMismatch,
		StoredProcedureLabelRedefine,
		StoredProcedureLabelMismatch,
		StoredProcedureUninitializedVariable,
		StoredProcedureBadSelect,
		StoredProcedureBadReturn,
		StoredProcedureBadStatement,
		UpdateLogDeprecatedIgnored,
		UpdateLogDeprecatedTranslated,
		QueryInterrupted,
		StoredProcedureNumberOfArguments,
		StoredProcedureConditionMismatch,
		StoredProcedureNoReturn,
		StoredProcedureNoReturnEnd,
		StoredProcedureBadCursorQuery,
		StoredProcedureBadCursorSelect,
		StoredProcedureCursorMismatch,
		StoredProcedureAlreadyOpen,
		StoredProcedureCursorNotOpen,
		StoredProcedureUndeclaredVariabel,
		StoredProcedureWrongNumberOfFetchArguments,
		StoredProcedureFetchNoData,
		StoredProcedureDuplicateParameter,
		StoredProcedureDuplicateVariable,
		StoredProcedureDuplicateCondition,
		StoredProcedureDuplicateCursor,
		StoredProcedureCannotAlter,
		StoredProcedureSubSelectNYI,
		StatementNotAllowedInStoredFunctionOrTrigger,
		StoredProcedureVariableConditionAfterCursorHandler,
		StoredProcedureCursorAfterHandler,
		StoredProcedureCaseNotFound,
		FileParserTooBigFile,
		FileParserBadHeader,
		FileParserEOFInComment,
		FileParserErrorInParameter,
		FileParserEOFInUnknownParameter,
		ViewNoExplain,
		FrmUnknownType,
		WrongObject,
		NonUpdateableColumn,
		ViewSelectDerived,
		ViewSelectClause,
		ViewSelectVariable,
		ViewSelectTempTable,
		ViewWrongList,
		WarningViewMerge,
		WarningViewWithoutKey,
		ViewInvalid,
		StoredProcedureNoDropStoredProcedure,
		StoredProcedureGotoInHandler,
		TriggerAlreadyExists,
		TriggerDoesNotExist,
		TriggerOnViewOrTempTable,
		TriggerCannotChangeRow,
		TriggerNoSuchRowInTrigger,
		NoDefaultForField,
		DivisionByZero,
		TruncatedWrongValueForField,
		IllegalValueForType,
		ViewNonUpdatableCheck,
		ViewCheckFailed,
		PrecedureAccessDenied,
		RelayLogFail,
		PasswordLength,
		UnknownTargetBinLog,
		IOErrorLogIndexRead,
		BinLogPurgeProhibited,
		FSeekFail,
		BinLogPurgeFatalError,
		LogInUse,
		LogPurgeUnknownError,
		RelayLogInit,
		NoBinaryLogging,
		ReservedSyntax,
		WSAStartupFailed,
		DifferentGroupsProcedure,
		NoGroupForProcedure,
		OrderWithProcedure,
		LoggingProhibitsChangingOf,
		NoFileMapping,
		WrongMagic,
		PreparedStatementManyParameters,
		KeyPartZero,
		ViewChecksum,
		ViewMultiUpdate,
		ViewNoInsertFieldList,
		ViewDeleteMergeView,
		CannotUser,
		XAERNotA,
		XAERInvalid,
		XAERRemoveFail,
		XAEROutside,
		XAERRemoveError,
		XARBRollback,
		NonExistingProcedureGrant,
		ProcedureAutoGrantFail,
		ProcedureAutoRevokeFail,
		DataTooLong,
		StoredProcedureSQLState,
		StartupError,
		LoadFromFixedSizeRowsToVariable,
		CannotCreateUserWithGrant,
		WrongValueForType,
		TableDefinitionChanged,
		StoredProcedureDuplicateHandler,
		StoredProcedureNotVariableArgument,
		StoredProcedureNoReturnSet,
		CannotCreateGeometryObject,
		FailedRoutineBreaksBinLog,
		BinLogUnsafeRoutine,
		BinLogCreateRoutineNeedSuper,
		ExecuteStatementWithOpenCursor,
		StatementHasNoOpenCursor,
		CommitNotAllowedIfStoredFunctionOrTrigger,
		NoDefaultForViewField,
		StoredProcedureNoRecursion,
		TooBigScale,
		TooBigPrecision,
		MBiggerThanD,
		WrongLockOfSystemTable,
		ConnectToForeignDataSource,
		QueryOnForeignDataSource,
		ForeignDataSourceDoesNotExist,
		ForeignDataStringInvalidCannotCreate,
		ForeignDataStringInvalid,
		CannotCreateFederatedTable,
		TriggerInWrongSchema,
		StackOverrunNeedMore,
		TooLongBody,
		WarningCannotDropDefaultKeyCache,
		TooBigDisplayWidth,
		XAERDuplicateID,
		DateTimeFunctionOverflow,
		CannotUpdateUsedTableInStoredFunctionOrTrigger,
		ViewPreventUpdate,
		PreparedStatementNoRecursion,
		StoredProcedureCannotSetAutoCommit,
		MalformedDefiner,
		ViewFrmNoUser,
		ViewOtherUser,
		NoSuchUser,
		ForbidSchemaChange,
		RowIsReferenced2,
		NoReferencedRow2,
		StoredProcedureBadVariableShadow,
		TriggerNoDefiner,
		OldFileFormat,
		StoredProcedureRecursionLimit,
		StoredProcedureTableCorrupt,
		StoredProcedureWrongName,
		TableNeedsUpgrade,
		StoredProcedureNoAggregate,
		MaxPreparedStatementCountReached,
		ViewRecursive,
		NonGroupingFieldUsed,
		TableCannotHandleSpatialKeys,
		NoTriggersOnSystemSchema,
		RemovedSpaces,
		AutoIncrementReadFailed,
		UserNameError,
		HostNameError,
		WrongStringLength,
		NonInsertableTable,
		AdminWrongMergeTable,
		TooHighLevelOfNestingForSelect,
		NameBecomesEmpty,
		AmbiguousFieldTerm,
		ForeignServerExists,
		ForeignServerDoesNotExist,
		IllegalHACreateOption,
		PartitionRequiresValues,
		PartitionWrongValues,
		PartitionMaxValue,
		PartitionSubPartition,
		PartitionSubPartMix,
		PartitionWrongNoPart,
		PartitionWrongNoSubPart,
		WrongExpressionInParitionFunction,
		NoConstantExpressionInRangeOrListError,
		FieldNotFoundPartitionErrror,
		ListOfFieldsOnlyInHash,
		InconsistentPartitionInfo,
		PartitionFunctionNotAllowed,
		PartitionsMustBeDefined,
		RangeNotIncreasing,
		InconsistentTypeOfFunctions,
		MultipleDefinitionsConstantInListPartition,
		PartitionEntryError,
		MixHandlerError,
		PartitionNotDefined,
		TooManyPartitions,
		SubPartitionError,
		CannotCreateHandlerFile,
		BlobFieldInPartitionFunction,
		UniqueKeyNeedAllFieldsInPartitioningFunction,
		NoPartitions,
		PartitionManagementOnNoPartitioned,
		ForeignKeyOnPartitioned,
		DropPartitionNonExistent,
		DropLastPartition,
		CoalesceOnlyOnHashPartition,
		ReorganizeHashOnlyOnSameNumber,
		ReorganizeNoParameter,
		OnlyOnRangeListPartition,
		AddPartitionSubPartition,
		AddPartitionNoNewPartition,
		CoalescePartitionNoPartition,
		ReorganizePartitionNotExist,
		SameNamePartition,
		NoBinLog,
		ConsecutiveReorganizePartitions,
		ReorganizeOutsideRange,
		PartitionFunctionFailure,
		PartitionStateError,
		LimitedPartitionRange,
		PluginIsNotLoaded,
		WrongValue,
		NoPartitionForGivenValue,
		FileGroupOptionOnlyOnce,
		CreateFileGroupFailed,
		DropFileGroupFailed,
		TableSpaceAutoExtend,
		WrongSizeNumber,
		SizeOverflow,
		AlterFileGroupFailed,
		BinLogRowLogginFailed,
		BinLogRowWrongTableDefinition,
		BinLogRowRBRToSBR,
		EventAlreadyExists,
		EventStoreFailed,
		EventDoesNotExist,
		EventCannotAlter,
		EventDropFailed,
		EventIntervalNotPositiveOrTooBig,
		EventEndsBeforeStarts,
		EventExecTimeInThePast,
		EventOpenTableFailed,
		EventNeitherMExpresssionNorMAt,
		ColumnCountDoesNotMatchCorrupted,
		CannotLoadFromTable,
		EventCannotDelete,
		EventCompileError,
		EventSameName,
		EventDataTooLong,
		DropIndexForeignKey,
		WarningDeprecatedSyntaxWithVersion,
		CannotWriteLockLogTable,
		CannotLockLogTable,
		ForeignDuplicateKey,
		ColumnCountDoesNotMatchPleaseUpdate,
		TemoraryTablePreventSwitchOutOfRBR,
		StoredFunctionPreventsSwitchBinLogFormat,
		NDBCannotSwitchBinLogFormat,
		PartitionNoTemporary,
		PartitionConstantDomain,
		PartitionFunctionIsNotAllowed,
		DDLLogError,
		NullInValuesLessThan,
		WrongPartitionName,
		CannotChangeTransactionIsolation,
		DuplicateEntryAutoIncrementCase,
		EventModifyQueueError,
		EventSetVariableError,
		PartitionMergeError,
		CannotActivateLog,
		RBRNotAvailable,
		Base64DecodeError,
		EventRecursionForbidden,
		EventsDatabaseError,
		OnlyIntegersAllowed,
		UnsupportedLogEngine,
		BadLogStatement,
		CannotRenameLogTable,
		WrongParameterCountToNativeFCT,
		WrongParametersToNativeFCT,
		WrongParametersToStoredFCT,
		NativeFCTNameCollision,
		DuplicateEntryWithKeyName,
		BinLogPurgeEMFile,
		EventCannotCreateInThePast,
		EventCannotAlterInThePast,
		SlaveIncident,
		NoPartitionForGivenValueSilent,
		BinLogUnsafeStatement,
		SlaveFatalError,
		SlaveRelayLogReadFailure,
		SlaveRelayLogWriteFailure,
		SlaveCreateEventFailure,
		SlaveMasterComFailure,
		BinLogLoggingImpossible,
		ViewNoCreationContext,
		ViewInvalidCreationContext,
		StoredRoutineInvalidCreateionContext,
		TiggerCorruptedFile,
		TriggerNoCreationContext,
		TriggerInvalidCreationContext,
		EventInvalidCreationContext,
		TriggerCannotOpenTable,
		CannoCreateSubRoutine,
		SlaveAmbiguousExecMode,
		NoFormatDescriptionEventBeforeBinLogStatement,
		SlaveCorruptEvent,
		LoadDataInvalidColumn,
		LogPurgeNoFile,
		XARBTimeout,
		XARBDeadlock,
		NeedRePrepare,
		DelayedNotSupported,
		WarningNoMasterInfo,
		WarningOptionIgnored,
		WarningPluginDeleteBuiltIn,
		WarningPluginBusy,
		VariableIsReadonly,
		WarningEngineTransactionRollback,
		SlaveHeartbeatFailure,
		SlaveHeartbeatValueOutOfRange,
		NDBReplicationSchemaError,
		ConflictFunctionParseError,
		ExcepionsWriteError,
		TooLongTableComment,
		TooLongFieldComment,
		FunctionInExistentNameCollision,
		DatabaseNameError,
		TableNameErrror,
		PartitionNameError,
		SubPartitionNameError,
		TemporaryNameError,
		RenamedNameError,
		TooManyConcurrentTransactions,
		WarningNonASCIISeparatorNotImplemented,
		DebugSyncTimeout,
		DebugSyncHitLimit,
		ErrorLast = 1640
	}
}
