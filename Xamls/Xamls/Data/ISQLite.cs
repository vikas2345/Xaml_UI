﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xamls.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
