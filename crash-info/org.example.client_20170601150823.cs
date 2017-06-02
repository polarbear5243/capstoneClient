S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 3386
Date: 2017-06-01 15:08:23+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 3386, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000d3a
r2   = 0x00000006, r3   = 0xb40d14c0
r4   = 0x00000002, r5   = 0xb40d1000
r6   = 0xb67cb09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ef9708
r10  = 0xb9249dd0, fp   = 0x800940a3
ip   = 0x00000000, sp   = 0xbe9f8eb4
lr   = 0xb66c1f18, pc   = 0xb66c0b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     68844 KB
Buffers:     77496 KB
Cached:     273116 KB
VmPeak:     135320 KB
VmSize:     135144 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29412 KB
VmRSS:       29412 KB
VmData:      47248 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35756 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3386 TID = 3386
3386 3387 3446 3447 3454 

Maps Information
af22e000 afa2d000 rw-p [stack:3454]
b138e000 b1396000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13a8000 b1ba7000 rw-p [stack:3447]
b1ba7000 b1ba8000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bb8000 b1bcc000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be0000 b1be1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf1000 b1bf4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c05000 b1c06000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c16000 b1c18000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c28000 b1c2a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c3a000 b1c4a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c5a000 b1c66000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c78000 b2477000 rw-p [stack:3446]
b27a8000 b27af000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c2000 b27c8000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27d8000 b2804000 r-xp /opt/usr/apps/org.example.client/bin/client
b295d000 b2a40000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a77000 b2a9f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab1000 b32b0000 rw-p [stack:3387]
b32b0000 b32b2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c2000 b32cc000 r-xp /lib/libnss_files-2.20-2014.11.so
b32dd000 b32e6000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f7000 b3308000 r-xp /lib/libnsl-2.20-2014.11.so
b331b000 b3321000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3332000 b3333000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335b000 b3362000 r-xp /usr/lib/libminizip.so.1.0.0
b3372000 b3377000 r-xp /usr/lib/libstorage.so.0.1
b3387000 b33e6000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fc000 b3410000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3420000 b3464000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3474000 b347c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348c000 b34bc000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34cf000 b3588000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359c000 b35ef000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3600000 b361b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362b000 b36ec000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36ff000 b370f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b371f000 b372c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373d000 b3744000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3754000 b3795000 r-xp /usr/lib/libmdm.so.1.2.12
b37a5000 b37ad000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37bc000 b37cc000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ed000 b384d000 r-xp /usr/lib/libasound.so.2.0.0
b385f000 b3862000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3872000 b3875000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3885000 b388a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b389a000 b389b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ab000 b38b6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ca000 b38d1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e1000 b38e7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f7000 b38fc000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390c000 b3927000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3937000 b393e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b394e000 b3951000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3962000 b3990000 r-xp /usr/lib/libidn.so.11.5.44
b39a0000 b39b6000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c7000 b39d1000 r-xp /usr/lib/libcares.so.2.1.0
b39e1000 b39eb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fb000 b39fd000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0d000 b3a0e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a1e000 b3a22000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a33000 b3a5b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6c000 b3a95000 r-xp /usr/lib/libturbojpeg.so
b3ab5000 b3abb000 r-xp /usr/lib/libgif.so.4.1.6
b3acb000 b3b11000 r-xp /usr/lib/libcurl.so.4.3.0
b3b22000 b3b43000 r-xp /usr/lib/libexif.so.12.3.3
b3b5e000 b3b73000 r-xp /usr/lib/libtts.so
b3b84000 b3b8c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9c000 b3c62000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c82000 b3d7a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d99000 b3e67000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e7e000 b3e80000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e90000 b3e96000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea6000 b3ec9000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eda000 b3edc000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eec000 b3eee000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eff000 b3f04000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1b000 b3f1d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2d000 b3f34000 r-xp /usr/lib/libsensord-share.so
b3f44000 b3f5c000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6d000 b3f70000 r-xp /usr/lib/libXv.so.1.0.0
b3f80000 b3f85000 r-xp /usr/lib/libutilX.so.1.1.0
b3f95000 b3f9a000 r-xp /usr/lib/libappcore-common.so.1.1
b3faa000 b3fb1000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc4000 b3fc8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fd9000 b40b7000 r-xp /usr/lib/libCOREGL.so.4.0
b40d7000 b40da000 r-xp /usr/lib/libuuid.so.1.3.0
b40ea000 b4101000 r-xp /usr/lib/libblkid.so.1.1.0
b4112000 b4114000 r-xp /usr/lib/libXau.so.6.0.0
b4124000 b416b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417d000 b4183000 r-xp /usr/lib/libjson-c.so.2.0.1
b4194000 b4198000 r-xp /usr/lib/libogg.so.0.7.1
b41a8000 b41ca000 r-xp /usr/lib/libvorbis.so.0.4.3
b41da000 b42be000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42da000 b42dd000 r-xp /usr/lib/libEGL.so.1.4
b42ee000 b42f4000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4304000 b4306000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4316000 b4323000 r-xp /usr/lib/libGLESv2.so.2.0
b4334000 b4396000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ab000 b43c3000 r-xp /usr/lib/libmount.so.1.1.0
b43d5000 b43e9000 r-xp /usr/lib/libxcb.so.1.1.0
b43f9000 b4400000 r-xp /lib/libcrypt-2.20-2014.11.so
b4438000 b443a000 r-xp /usr/lib/libiri.so
b444a000 b4455000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4466000 b449c000 r-xp /usr/lib/libpulse.so.0.16.2
b44ad000 b44f0000 r-xp /usr/lib/libsndfile.so.1.0.25
b4505000 b451a000 r-xp /lib/libexpat.so.1.5.2
b452c000 b45ea000 r-xp /usr/lib/libcairo.so.2.11200.14
b45fe000 b4606000 r-xp /usr/lib/libdrm.so.2.4.0
b4616000 b4619000 r-xp /usr/lib/libdri2.so.0.0.0
b4629000 b4677000 r-xp /usr/lib/libssl.so.1.0.0
b468c000 b4698000 r-xp /usr/lib/libeeze.so.1.13.0
b46a9000 b46b2000 r-xp /usr/lib/libethumb.so.1.13.0
b46c2000 b46c5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d5000 b488c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5677000 b5680000 r-xp /usr/lib/libXi.so.6.1.0
b5690000 b5692000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a2000 b56a6000 r-xp /usr/lib/libXtst.so.6.1.0
b56b6000 b56bc000 r-xp /usr/lib/libXrender.so.1.3.0
b56cc000 b56d2000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e2000 b56e4000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f5000 b56f8000 r-xp /usr/lib/libXfixes.so.3.1.0
b5708000 b5713000 r-xp /usr/lib/libXext.so.6.4.0
b5723000 b5725000 r-xp /usr/lib/libXdamage.so.1.1.0
b5735000 b5737000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5747000 b5829000 r-xp /usr/lib/libX11.so.6.3.0
b583d000 b5844000 r-xp /usr/lib/libXcursor.so.1.0.2
b5854000 b586c000 r-xp /usr/lib/libudev.so.1.6.0
b586e000 b5871000 r-xp /lib/libattr.so.1.1.0
b5881000 b58a1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a2000 b58a7000 r-xp /usr/lib/libffi.so.6.0.2
b58b8000 b58d0000 r-xp /lib/libz.so.1.2.8
b58e0000 b58e2000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f2000 b59c7000 r-xp /usr/lib/libxml2.so.2.9.2
b59dc000 b5a77000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a93000 b5a96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa6000 b5abf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad0000 b5ae1000 r-xp /lib/libresolv-2.20-2014.11.so
b5af5000 b5b6f000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b84000 b5b86000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b96000 b5b9d000 r-xp /usr/lib/libembryo.so.1.13.0
b5bad000 b5bb7000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bc8000 b5be0000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf1000 b5c14000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c35000 b5c49000 r-xp /usr/lib/libector.so.1.13.0
b5c5a000 b5c72000 r-xp /usr/lib/liblua-5.1.so
b5c83000 b5cda000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cee000 b5d16000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d27000 b5d3a000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4b000 b5d85000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d96000 b5da4000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db4000 b5dbc000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcc000 b5dd9000 r-xp /usr/lib/libeio.so.1.13.0
b5de9000 b5deb000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfb000 b5e00000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e10000 b5e27000 r-xp /usr/lib/libefreet.so.1.13.0
b5e39000 b5e59000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e69000 b5e89000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8b000 b5e91000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea1000 b5eb2000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec3000 b5eca000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eda000 b5ee9000 r-xp /usr/lib/libeo.so.1.13.0
b5efa000 b5f0c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1d000 b5f22000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f32000 b5f4b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5b000 b5f78000 r-xp /usr/lib/libeet.so.1.13.0
b5f91000 b5fd9000 r-xp /usr/lib/libeina.so.1.13.0
b5fea000 b5ffa000 r-xp /usr/lib/libefl.so.1.13.0
b600b000 b60f0000 r-xp /usr/lib/libicuuc.so.51.1
b610d000 b624d000 r-xp /usr/lib/libicui18n.so.51.1
b6264000 b629c000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ae000 b62b1000 r-xp /lib/libcap.so.2.21
b62c1000 b62ea000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fb000 b6302000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6314000 b634b000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635c000 b6447000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645a000 b64d3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e5000 b64ea000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fa000 b6504000 r-xp /usr/lib/libvconf.so.0.2.45
b6514000 b6516000 r-xp /usr/lib/libvasum.so.0.3.1
b6526000 b6528000 r-xp /usr/lib/libttrace.so.1.1
b6538000 b653b000 r-xp /usr/lib/libiniparser.so.0
b654b000 b6571000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6581000 b6586000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6597000 b65ae000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65bf000 b662a000 r-xp /lib/libm-2.20-2014.11.so
b663b000 b6641000 r-xp /lib/librt-2.20-2014.11.so
b6652000 b665f000 r-xp /usr/lib/libunwind.so.8.0.1
b6695000 b67b9000 r-xp /lib/libc-2.20-2014.11.so
b67ce000 b67e7000 r-xp /lib/libgcc_s-4.9.so.1
b67f7000 b68d9000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ea000 b6914000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6925000 b6961000 r-xp /usr/lib/libsystemd.so.0.4.0
b6963000 b69e6000 r-xp /usr/lib/libedje.so.1.13.0
b69f9000 b6a17000 r-xp /usr/lib/libecore.so.1.13.0
b6a37000 b6bbe000 r-xp /usr/lib/libevas.so.1.13.0
b6bf3000 b6c07000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1b000 b6e4f000 r-xp /usr/lib/libelementary.so.1.13.0
b6e7e000 b6e82000 r-xp /usr/lib/libsmack.so.1.0.0
b6e92000 b6e99000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea9000 b6eab000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebb000 b6ebe000 r-xp /usr/lib/libbundle.so.0.1.22
b6ece000 b6ed0000 r-xp /lib/libdl-2.20-2014.11.so
b6ee1000 b6ef9000 r-xp /usr/lib/libaul.so.0.1.0
b6f0d000 b6f12000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f23000 b6f30000 r-xp /usr/lib/liblptcp.so
b6f42000 b6f46000 r-xp /usr/lib/libsys-assert.so
b6f57000 b6f77000 r-xp /lib/ld-2.20-2014.11.so
b6f88000 b6f8d000 r-xp /usr/bin/launchpad-loader
b8e78000 b92cf000 rw-p [heap]
be9d9000 be9fa000 rw-p [stack]
be9d9000 be9fa000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3386)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66c0b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-01 15:07:49.208+0900 E/PKGMGR_PARSER( 3317): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-01 15:07:49.218+0900 E/PKGMGR_PARSER( 3317): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-01 15:07:49.248+0900 I/PRIVACY-MANAGER-CLIENT( 3317): SocketClient.cpp: SocketClient(37) > Client created
06-01 15:07:49.458+0900 E/PKGMGR_PARSER( 3317): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
06-01 15:07:49.488+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-01 15:07:49.488+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.488+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-01 15:07:49.488+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
06-01 15:07:49.488+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
06-01 15:07:49.488+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.508+0900 E/rpm-installer( 3317): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-01 15:07:49.528+0900 E/rpm-installer( 3317): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-01 15:07:49.538+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
06-01 15:07:49.538+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:50.839+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-01 15:07:51.400+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-01 15:07:51.400+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
06-01 15:07:51.400+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-01 15:07:51.400+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
06-01 15:07:51.400+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.420+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.430+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-01 15:07:51.440+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-01 15:07:51.450+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (840) > Enter.
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (703) > Exit.
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-01 15:07:51.470+0900 I/Tizen::App( 1233): (131) > Enter
06-01 15:07:51.470+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-01 15:07:51.470+0900 I/Tizen::App( 1233): (883) > Exit.
06-01 15:07:51.470+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3317]
06-01 15:07:51.480+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-01 15:07:51.480+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-01 15:07:51.480+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-01 15:07:51.480+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-01 15:07:51.500+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-01 15:07:51.510+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-01 15:07:52.841+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 15:07:52.841+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: main(2471) > package manager server terminated.
06-01 15:07:55.594+0900 W/AUL     ( 3373): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-01 15:07:55.594+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-01 15:07:55.604+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-01 15:07:55.614+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-01 15:07:55.614+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-01 15:07:55.614+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 3373
06-01 15:07:55.614+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-01 15:07:55.624+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-01 15:07:55.624+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 15:07:55.624+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-01 15:07:55.634+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-01 15:07:55.634+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-01 15:07:55.644+0900 I/abc     ( 3110): abc
06-01 15:07:55.644+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: ui_app_main(789) > app_efl_main
06-01 15:07:55.644+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-01 15:07:55.684+0900 E/TBM     ( 3110): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-01 15:07:55.734+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3110, appid: org.example.client
06-01 15:07:55.734+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-01 15:07:55.734+0900 W/AUL     ( 3373): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3110)
06-01 15:07:55.944+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(514) > [APP 3110] Event: RESET State: CREATED
06-01 15:07:55.944+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-01 15:07:55.954+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:07:55.954+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:07:55.964+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:07:55.964+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:07:55.964+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:07:55.964+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:07:55.974+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:07:55.974+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:07:55.974+0900 W/APP_CORE( 3110): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-01 15:07:55.974+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-01 15:07:55.994+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-01 15:07:55.994+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:07:55.994+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:07:56.004+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 15:07:56.084+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-01 15:07:56.084+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-01 15:07:56.084+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-01 15:07:56.084+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-01 15:07:56.084+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-01 15:07:56.084+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-01 15:07:56.094+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(3110) status(3)
06-01 15:07:56.094+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(514) > [APP 3110] Event: RESUME State: CREATED
06-01 15:07:56.094+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 15:07:56.094+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-01 15:07:56.094+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(3110)
06-01 15:07:56.094+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3110, appid: org.example.client, status: fg
06-01 15:07:56.104+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-01 15:07:56.104+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-01 15:07:56.104+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-01 15:07:56.114+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-01 15:07:56.114+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(625) > [APP 3110] Initial Launching, call the resume_cb
06-01 15:07:56.114+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-01 15:07:56.455+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(3110) status(0)
06-01 15:07:56.795+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-01 15:07:56.795+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1896
06-01 15:07:56.805+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 3110.
06-01 15:07:57.556+0900 I/UXT     ( 3386): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-01 15:07:58.307+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845875469
06-01 15:07:58.307+0900 I/MY_LOG  ( 3110): Button pressed
06-01 15:07:58.417+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845875579
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: vconf_get_bool(2729) > vconf_get_bool(3110) : db/ise/keysound error
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-01 15:07:58.477+0900 I/MY_LOG  ( 3110): Button unpressed
06-01 15:07:59.057+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845876218
06-01 15:07:59.057+0900 I/MY_LOG  ( 3110): Button pressed
06-01 15:07:59.137+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845876305
06-01 15:07:59.147+0900 I/MY_LOG  ( 3110): Button unpressed
06-01 15:07:59.177+0900 D/basicui ( 3110): successed to load edc file
06-01 15:07:59.197+0900 E/EFL     ( 3110): elementary<3110> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x800787c5 into part 'swallow_content'
06-01 15:08:00.098+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-01 15:08:00.108+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 3:08
06-01 15:08:00.108+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 3:08"
06-01 15:08:00.108+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 3:08"
06-01 15:08:00.108+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-01 15:08:00.108+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145540527 Time: <font_size=31> </font_size> <font_size=31> 오후 3:08</font_size></font>"
06-01 15:08:01.099+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-01 15:08:01.530+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845878697
06-01 15:08:01.620+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845878785
06-01 15:08:01.680+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-01 15:08:01.680+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:08:02.621+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845879784
06-01 15:08:02.711+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845879871
06-01 15:08:02.851+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:08:02.861+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-01 15:08:02.861+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 3110 pgid = 3110
06-01 15:08:02.861+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 15:08:02.861+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-01 15:08:02.861+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(3110)
06-01 15:08:02.861+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-01 15:08:02.861+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-01 15:08:02.931+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-01 15:08:02.931+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-01 15:08:02.931+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-01 15:08:02.931+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[3110] terminate event is forwarded
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 3110, ]
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-01 15:08:02.931+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-01 15:08:02.931+0900 I/Tizen::App( 1233): (512) > Not registered pid(3110)
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-01 15:08:02.931+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:08:02.931+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 3110
06-01 15:08:02.931+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:08:02.941+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-01 15:08:02.941+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-01 15:08:02.941+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-01 15:08:02.941+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 3110
06-01 15:08:02.941+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 3110
06-01 15:08:02.941+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1900
06-01 15:08:02.951+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-01 15:08:02.961+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:08:02.961+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 3110.
06-01 15:08:02.971+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-01 15:08:02.991+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-01 15:08:02.991+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:08:03.011+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:08:03.031+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-01 15:08:03.041+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-01 15:08:03.041+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-01 15:08:03.041+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-01 15:08:03.041+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-01 15:08:03.051+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 15:08:03.061+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-01 15:08:03.081+0900 W/CRASH_MANAGER( 3391): worker.c: worker_job(1199) > 0603110636c691496297282
06-01 15:08:03.111+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8278eb0]
06-01 15:08:03.111+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-01 15:08:03.121+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8278eb0
06-01 15:08:03.121+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-01 15:08:03.121+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-01 15:08:03.121+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-01 15:08:03.121+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-01 15:08:03.121+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-01 15:08:15.634+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845892795
06-01 15:08:15.654+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845892817
06-01 15:08:15.664+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-01 15:08:15.664+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 1
06-01 15:08:15.664+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 867
06-01 15:08:15.674+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-01 15:08:15.674+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 15:08:15.684+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-01 15:08:15.684+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-01 15:08:15.684+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-01 15:08:15.694+0900 I/abc     ( 3386): abc
06-01 15:08:15.694+0900 I/CAPI_APPFW_APPLICATION( 3386): app_main.c: ui_app_main(789) > app_efl_main
06-01 15:08:15.704+0900 I/CAPI_APPFW_APPLICATION( 3386): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-01 15:08:15.724+0900 E/TBM     ( 3386): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-01 15:08:15.784+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3386, appid: org.example.client
06-01 15:08:15.784+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-01 15:08:15.784+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(425) > request cmd(1) result(3386)
06-01 15:08:15.994+0900 I/APP_CORE( 3386): appcore-efl.c: __do_app(514) > [APP 3386] Event: RESET State: CREATED
06-01 15:08:15.994+0900 I/CAPI_APPFW_APPLICATION( 3386): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-01 15:08:16.004+0900 E/EFL     ( 3386): edje<3386> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:08:16.004+0900 E/EFL     ( 3386): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:08:16.014+0900 E/EFL     ( 3386): edje<3386> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:08:16.014+0900 E/EFL     ( 3386): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:08:16.014+0900 E/EFL     ( 3386): edje<3386> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:08:16.014+0900 E/EFL     ( 3386): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:08:16.024+0900 W/APP_CORE( 3386): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
06-01 15:08:16.024+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:08:16.024+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:08:16.024+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-01 15:08:16.044+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-01 15:08:16.044+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:08:16.054+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:08:16.054+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 15:08:16.134+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-01 15:08:16.134+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-01 15:08:16.134+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-01 15:08:16.144+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-01 15:08:16.144+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-01 15:08:16.144+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-01 15:08:16.144+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(3386) status(3)
06-01 15:08:16.144+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(3386)
06-01 15:08:16.144+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3386, appid: org.example.client, status: fg
06-01 15:08:16.154+0900 I/APP_CORE( 3386): appcore-efl.c: __do_app(514) > [APP 3386] Event: RESUME State: CREATED
06-01 15:08:16.154+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-01 15:08:16.154+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-01 15:08:16.154+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-01 15:08:16.164+0900 I/APP_CORE( 3386): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-01 15:08:16.164+0900 I/APP_CORE( 3386): appcore-efl.c: __do_app(625) > [APP 3386] Initial Launching, call the resume_cb
06-01 15:08:16.164+0900 I/CAPI_APPFW_APPLICATION( 3386): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-01 15:08:16.504+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(3386) status(0)
06-01 15:08:16.825+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-01 15:08:16.835+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1902
06-01 15:08:16.845+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 3386.
06-01 15:08:17.005+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845894172
06-01 15:08:17.035+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845894205
06-01 15:08:17.355+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845894528
06-01 15:08:17.365+0900 I/MY_LOG  ( 3386): Button pressed
06-01 15:08:17.435+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845894605
06-01 15:08:17.435+0900 E/VCONF   ( 3386): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-01 15:08:17.435+0900 E/VCONF   ( 3386): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-01 15:08:17.435+0900 E/VCONF   ( 3386): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-01 15:08:17.435+0900 E/VCONF   ( 3386): vconf.c: vconf_get_bool(2729) > vconf_get_bool(3386) : db/ise/keysound error
06-01 15:08:17.435+0900 E/VCONF   ( 3386): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-01 15:08:17.445+0900 E/VCONF   ( 3386): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-01 15:08:17.475+0900 I/MY_LOG  ( 3386): Button unpressed
06-01 15:08:17.675+0900 I/UXT     ( 3452): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-01 15:08:18.036+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845895198
06-01 15:08:18.036+0900 I/MY_LOG  ( 3386): Button pressed
06-01 15:08:18.106+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845895264
06-01 15:08:18.106+0900 I/MY_LOG  ( 3386): Button unpressed
06-01 15:08:18.136+0900 D/basicui ( 3386): successed to load edc file
06-01 15:08:18.166+0900 E/EFL     ( 3386): elementary<3386> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8007b9de into part 'swallow_content'
06-01 15:08:20.779+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845897940
06-01 15:08:20.849+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845898017
06-01 15:08:20.909+0900 E/EFL     ( 3386): edje<3386> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-01 15:08:20.909+0900 E/EFL     ( 3386): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:08:21.139+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-01 15:08:23.531+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845900696
06-01 15:08:23.611+0900 E/EFL     ( 3386): ecore_x<3386> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845900773
06-01 15:08:23.721+0900 W/CRASH_MANAGER( 3391): worker.c: worker_job(1199) > 0603386636c69149629730
