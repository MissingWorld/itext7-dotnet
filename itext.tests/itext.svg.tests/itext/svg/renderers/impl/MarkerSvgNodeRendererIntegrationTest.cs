/*
This file is part of the iText (R) project.
Copyright (c) 1998-2020 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using iText.Svg.Processors;
using iText.Svg.Processors.Impl;
using iText.Svg.Renderers;
using iText.Test;
using iText.Test.Attributes;

namespace iText.Svg.Renderers.Impl {
    public class MarkerSvgNodeRendererIntegrationTest : SvgIntegrationTest {
        private static readonly String SOURCE_FOLDER = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/svg/renderers/impl/MarkerSvgNodeRendererIntegrationTest/";

        private static readonly String DESTINATION_FOLDER = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/svg/renderers/impl/MarkerSvgNodeRendererIntegrationTest/";

        private ISvgConverterProperties properties;

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            ITextTest.CreateDestinationFolder(DESTINATION_FOLDER);
        }

        [NUnit.Framework.SetUp]
        public virtual void Before() {
            properties = new SvgConverterProperties().SetBaseUri(SOURCE_FOLDER);
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathAutoOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathAutoOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathAngleOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathAngleOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathRefXRefYNoAspectRatioPreservationTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathRefXRefYNoAspectRatioPreservationTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathRefXAndRefYTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathAutoOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathViewboxRightOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathViewboxRightOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathViewboxRightOrientNoAspectRatioPreservationTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathViewboxRightOrientNoAspectRatioPreservationTest"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathViewboxLeftOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathViewboxLeftOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathViewboxUpOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathViewboxUpOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathViewboxDownOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathViewboxDownOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathViewboxAngledOrientTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathViewboxAngledOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerPathPreserveAspectRatioTest() {
            ConvertAndCompare(SOURCE_FOLDER, DESTINATION_FOLDER, "markerPathPreserveAspectRatioTest");
        }

        // Markers in different elements
        [NUnit.Framework.Test]
        public virtual void MarkerTest() {
            // TODO: update when DEVSIX-3397 will be closed
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInLineElementTest() {
            // TODO: update when DEVSIX-3397 will be closed
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInLineElementTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInPolylineElementTest() {
            // TODO: update when DEVSIX-3397 will be closed
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInPolylineElementTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInPolygonElementTest() {
            // TODO: update when DEVSIX-3397, DEVSIX-2719 will be closed
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInPolygonElementTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInPathTest() {
            // TODO: update when DEVSIX-3397 will be closed
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInPathTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerUnitsTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerUnitsTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerRefXYTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerRefXYTest");
        }

        // orient attribute tests
        [NUnit.Framework.Test]
        public virtual void MarkerOrientTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOrientTest");
        }

        [NUnit.Framework.Test]
        public virtual void OrientAutoLineInDifferentPositionTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "orientAutoLineInDifferentPosition");
        }

        [NUnit.Framework.Test]
        public virtual void OrientAutoPolylineInDifferentPositionTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "orientAutoPolylineInDifferentPosition");
        }

        [NUnit.Framework.Test]
        public virtual void OrientAutoPolygonInDifferentPositionTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "orientAutoPolygonInDifferentPosition");
        }

        [NUnit.Framework.Test]
        // TODO: update when DEVSIX-3432 will be fixed
        [LogMessage(iText.StyledXmlParser.LogMessageConstant.UNKNOWN_ABSOLUTE_METRIC_LENGTH_PARSED, Count = 3)]
        public virtual void TestMarkerUnitsStrokeWidthWhenParentStrokeWidthIsFontRelativeValues() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "testMarkerUnitsStrokeWidthWhenParentStrokeWidthIsFontRelativeValues"
                );
        }

        [NUnit.Framework.Test]
        public virtual void TestMarkerUnitsStrokeWidthWhenParentStrokeWidthIsMetricValues() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "testMarkerUnitsStrokeWidthWhenParentStrokeWidthIsMetricValues"
                );
        }

        [NUnit.Framework.Test]
        // TODO: update when DEVSIX-3432 will be fixed
        [LogMessage(iText.StyledXmlParser.LogMessageConstant.UNKNOWN_ABSOLUTE_METRIC_LENGTH_PARSED, Count = 3)]
        public virtual void TestMarkerUnitsStrokeWidthWhenParentStrokeWidthIsPercentageValues() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "testMarkerUnitsStrokeWidthWhenParentStrokeWidthIsPercentageValues"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerDefaultValuesTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerDefaultValuesTest");
        }

        // Style inheritance
        [NUnit.Framework.Test]
        public virtual void MarkerInheritFillAttributeTest0() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInheritFillAttributeTest0");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInheritFillAttributeTest1() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInheritFillAttributeTest1");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInheritFillAttributeTest2() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInheritFillAttributeTest2");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerInheritFillAttributeNestedMarker() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerInheritFillAttributeNestedMarker");
        }

        [NUnit.Framework.Test]
        public virtual void FontRelativeValueInRefX() {
            // This file is rendered differently in different browsers.
            // Look at MarkerSvgNOdeRenderer#parseFontRelativeOrAbsoluteLengthOnMarker to see the processing of font-relative unit .
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "fontRelativeValueInRefX");
        }

        [NUnit.Framework.Test]
        public virtual void FontRelativeValueInRefXDefault() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "fontRelativeValueInRefXDefault");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerAspectRatioTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerAspectRatioTest");
        }

        // Overflow attribute
        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleIncreaseViewBoxScaleRootElementTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleIncreaseViewBoxScaleRootElementTest"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleIncreaseViewBoxScaleSvgElementTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleIncreaseViewBoxScaleSvgElementTest"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleTransformScaleTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleTransformScaleTest");
        }

        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleTransformTranslateTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleTransformTranslateTest"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleNestedSvgViewBoxesTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleNestedSvgViewBoxesTest"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleNestedSvgViewBoxes2Test() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleNestedSvgViewBoxes2Test"
                );
        }

        [NUnit.Framework.Test]
        public virtual void MarkerOverflowVisibleTransformRotateTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerOverflowVisibleTransformRotateTest");
        }

        [NUnit.Framework.Test]
        [LogMessage("markerWidth has zero value. Marker will not be rendered.")]
        [LogMessage("markerHeight has zero value. Marker will not be rendered.")]
        [LogMessage("markerWidth has negative value. Marker will not be rendered.")]
        [LogMessage("markerHeight has negative value. Marker will not be rendered.")]
        public virtual void MarkerEspecialMarkerWidthHeightValuesTest() {
            ConvertAndCompareSinglePage(SOURCE_FOLDER, DESTINATION_FOLDER, "markerEspecialMarkerWidthHeightValuesTest"
                );
        }
    }
}
