using System;

namespace MySql.Data.MySqlClient
{
	internal enum ColumnFlags
	{
		NOT_NULL = 1,
		PRIMARY_KEY,
		UNIQUE_KEY = 4,
		MULTIPLE_KEY = 8,
		BLOB = 16,
		UNSIGNED = 32,
		ZERO_FILL = 64,
		BINARY = 128,
		ENUM = 256,
		AUTO_INCREMENT = 512,
		TIMESTAMP = 1024,
		SET = 2048,
		NUMBER = 32768
	}
}
